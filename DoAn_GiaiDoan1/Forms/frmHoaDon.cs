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
            var hoaDon = context.HoaDon
                .FirstOrDefault(x => x.DatPhongID == datPhongID);

            if (hoaDon == null) return;

            var ds = context.ChiTietHoaDon
                .Where(x => x.HoaDonID == hoaDon.ID && x.Loai == "DichVu")
                .Select(x => new
                {
                    ID = x.ID,
                    TenDV = x.Ten,
                    SoLuong = x.SoLuong,
                    DonGia = x.DonGia,
                    ThanhTien = x.ThanhTien
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
                context.SaveChanges();
            }

            hd.ThoiGianLap = DateTime.Now;
            hd.TongTien = tongTien;
            hd.KhuyenMaiID = khuyenMaiID;


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


            var hoaDon = context.HoaDon
                .FirstOrDefault(x => x.DatPhongID == datPhongID);

            if (hoaDon == null) return;

            var ds = context.ChiTietHoaDon
                .Where(x => x.HoaDonID == hoaDon.ID)
                .ToList();

            decimal tienPhong = ds
                .Where(x => x.Loai == "Phong")
                .Sum(x => x.ThanhTien);

            decimal tienDV = ds
                .Where(x => x.Loai == "DichVu")
                .Sum(x => x.ThanhTien);

            decimal tong = tienPhong + tienDV;

            decimal giam = 0;

            // XÓA giảm giá cũ
            var giamGiaCu = context.ChiTietHoaDon
                .Where(x => x.HoaDonID == hoaDon.ID && x.Loai == "KhuyenMai");

            context.ChiTietHoaDon.RemoveRange(giamGiaCu);

            if (cboKhuyenMai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin cho khuyến mãi!");
                return;
            }

            // LẤY KHUYẾN MÃI
            if (cboKhuyenMai.SelectedValue != null)
            {
                var km = context.KhuyenMai.Find((int)cboKhuyenMai.SelectedValue);

                if (km != null)
                {
                    giam = tong * km.PhanTramGiam / 100;

                    ChiTietHoaDon ct = new ChiTietHoaDon
                    {
                        HoaDonID = hoaDon.ID,
                        Loai = "KhuyenMai",
                        Ten = km.TenKhuyenMai,   
                        SoLuong = 1,
                        DonGia = km.PhanTramGiam,
                        ThanhTien = -giam
                    };

                    context.ChiTietHoaDon.Add(ct);
                }
            }

            context.SaveChanges();

            decimal thanhTien = tong - giam;

            txtTienPhong.Text = tienPhong.ToString("N0");
            txtTienDV.Text = tienDV.ToString("N0");
            txtTienGiam.Text = giam.ToString("N0");
            txtTongTien.Text = thanhTien.ToString("N0") + " đ";
        }
    }
}
