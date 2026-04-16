using QuanLyQuanKaraoke.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmHoaDon : Form
    {
        QLQKDbContext context = new QLQKDbContext();
        int datPhongID;
        HoaDon hoaDonHienTai;
        public frmHoaDon(int id)
        {
            InitializeComponent();
            datPhongID = id;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            LoadDichVu();
            LoadKhuyenMai();
        }

        void LoadThongTin()
        {
            var dp = context.DatPhong
                .Where(x => x.ID == datPhongID)
                .Select(x => new
                {
                    TenPhong = x.Phong.TenPhong,
                    TenKH = x.KhachHang.TenKH,
                    TenNV = x.NhanVien.TenNV,
                    ThoiGianBatDau = x.ThoiGianBatDau,
                    ThoiGianKetThuc = x.ThoiGianKetThuc
                })
                .FirstOrDefault();

            if (dp == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu!");
                return;
            }

            if (dp.ThoiGianKetThuc == null)
            {
                MessageBox.Show("Phòng chưa kết thúc!");
                this.Close();
                return;
            }

            txtPhong.Text = dp.TenPhong;
            txtKhachHang.Text = dp.TenKH;
            txtNhanVien.Text = dp.TenNV;
            txtThoiGianBatDau.Text = dp.ThoiGianBatDau.ToString();
            txtThoiGianKetThuc.Text = dp.ThoiGianKetThuc.ToString();
        }

        void LoadDichVu()
        {
            var ds = context.SuDungDichVu
                .Where(x => x.DatPhongID == datPhongID)
                .Select(x => new
                {
                    ID = x.ID,
                    DatPhongID = x.DatPhongID,
                    DichVuID = x.DichVuID,
                    TenDV = x.DichVu.TenDV,
                    SoLuong = x.SoLuong,
                    DonGia = x.DichVu.DonGia,
                    ThanhTien = x.SoLuong * x.DichVu.DonGia
                }).ToList();

            dataGridView1.DataSource = ds;
        }
        void LoadKhuyenMai()
        {
            cboKhuyenMai.DataSource = context.KhuyenMai.ToList();
            cboKhuyenMai.DisplayMember = "TenKhuyenMai";
            cboKhuyenMai.ValueMember = "ID";
            cboKhuyenMai.SelectedIndexChanged += cboKhuyenMai_SelectedIndexChanged;
            cboKhuyenMai.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTongTien.Text))
            {
                MessageBox.Show("Vui lòng tính tiền trước!");
                return;
            }

            // lấy dữ liệu
            decimal tienPhong = decimal.Parse(txtTienPhong.Text.Replace(",", ""));
            decimal tienDV = decimal.Parse(txtTienDV.Text.Replace(",", ""));
            decimal tienGiam = decimal.Parse(txtTienGiam.Text.Replace(",", ""));
            decimal tongTien = decimal.Parse(txtTongTien.Text.Replace("đ", "").Replace(",", "").Trim());

            int? khuyenMaiID = null;
            if (cboKhuyenMai.SelectedValue != null)
                khuyenMaiID = (int)cboKhuyenMai.SelectedValue;

            // lập hóa đơn
            var hd = context.HoaDon.FirstOrDefault(x => x.DatPhongID == datPhongID);

            if (hd == null)
            {
                hd = new HoaDon();
                hd.DatPhongID = datPhongID;
                context.HoaDon.Add(hd);
            }

            hd.ThoiGianLap = DateTime.Now;
            hd.TongTien = tongTien;
            hd.KhuyenMaiID = khuyenMaiID;

            context.SaveChanges();


            var chiTiet = context.ChiTietHoaDon
                .Where(x => x.HoaDonID == hd.ID)
                .ToList();

            context.ChiTietHoaDon.RemoveRange(chiTiet);

            // them vào chi tiết hóa đơn
            context.ChiTietHoaDon.Add(new ChiTietHoaDon
            {
                HoaDonID = hd.ID,
                GhiChu = "Tiền phòng",
                ThanhTien = tienPhong
            });

            context.ChiTietHoaDon.Add(new ChiTietHoaDon
            {
                HoaDonID = hd.ID,
                GhiChu = "Tiền dịch vụ",
                ThanhTien = tienDV
            });

            context.ChiTietHoaDon.Add(new ChiTietHoaDon
            {
                HoaDonID = hd.ID,
                GhiChu = "Giảm giá",
                ThanhTien = tienGiam
            });

            context.SaveChanges();

            MessageBox.Show("Lưu hóa đơn thành công!");

        }

        private void cboKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhuyenMai.SelectedItem == null) return;

            var km = cboKhuyenMai.SelectedItem as KhuyenMai;

            if (km != null)
            {
                txtGiamGia.Text = km.PhanTramGiam + " %";
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            var dp = context.DatPhong.Find(datPhongID);

            double gio = (dp.ThoiGianKetThuc.Value - dp.ThoiGianBatDau).TotalHours;

            decimal gia = context.Phong
                .Where(p => p.ID == dp.PhongID)
                .Select(p => p.LoaiPhong.GiaGio)
                .FirstOrDefault();

            decimal tienPhong = (decimal)gio * gia;

            decimal tienDV = context.SuDungDichVu
                .Where(sd => sd.DatPhongID == datPhongID)
                .Join(context.DichVu,
                    sd => sd.DichVuID,
                    dv => dv.ID,
                    (sd, dv) => sd.SoLuong * dv.DonGia)
                .Sum();

            decimal tong = tienPhong + tienDV;

            decimal giam = 0;

            if (cboKhuyenMai.SelectedValue != null)
            {
                var km = context.KhuyenMai.Find((int)cboKhuyenMai.SelectedValue);
                giam = tong * km.PhanTramGiam / 100;
            }

            decimal thanhTien = tong - giam;

            // HIỂN THỊ
            txtTienPhong.Text = tienPhong.ToString("N0");
            txtTienDV.Text = tienDV.ToString("N0");
            txtTienGiam.Text = giam.ToString("N0");
            txtTongTien.Text = thanhTien.ToString("N0") + " đ";
        }
    }
}
