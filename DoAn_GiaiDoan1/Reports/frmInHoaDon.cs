using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyQuanKaraoke.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.Reports
{
    public partial class frmInHoaDon : Form
    {
        QLQKDbContext context = new QLQKDbContext();
        //QLQKDataSet.DanhSachHoaDon_ChiTietDataTable danhSachHoaDon_ChiTietDataTable = new QLQKDataSet.DanhSachHoaDon_ChiTietDataTable();
        QLQKDataSet.DanhSachSuDungDichVuDataTable danhSachSuDungDichVuDataTable = new QLQKDataSet.DanhSachSuDungDichVuDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        int id;
        public frmInHoaDon(int mahoadon = 0)
        {
            InitializeComponent();
            id = mahoadon;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon
                .Include(r => r.DatPhong)
                    .ThenInclude(dp => dp.KhachHang)
                .Include(r => r.DatPhong)
                    .ThenInclude(dp => dp.Phong)
                .Include(r => r.ChiTietHoaDon)
                .Include(r => r.KhuyenMai)
                .SingleOrDefault(r => r.ID == id);

            if (hoaDon == null) return;

            /*var danhSachHoaDon = context.HoaDon.Where(r => r.ID == id).Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                DatPhongID = r.DatPhongID,
                PhongID = r.DatPhong.PhongID,
                TenPhong = r.DatPhong.Phong.TenPhong,
                NhanVienID = r.DatPhong.NhanVienID,
                TenNV = r.DatPhong.NhanVien.TenNV,
                KhachHangID = r.DatPhong.KhachHangID,
                TenKH = r.DatPhong.KhachHang.TenKH,
                KhuyenMaiID = r.KhuyenMaiID,
                TenKhuyenMai = r.KhuyenMai.TenKhuyenMai,
                ThoiGianLap = r.ThoiGianLap,
                TongTien = r.TongTien,
            }).ToList();*/

            var dsDV = context.SuDungDichVu
                .Where(x => x.DatPhongID == hoaDon.DatPhong.ID)
                .Select(x => new DanhSachSuDungDichVu2
                {
                    ID = x.ID,
                    DatPhongID = x.DatPhongID,
                    DichVuID = x.DichVuID,
                    TenDV = x.DichVu.TenDV,
                    SoLuong = x.SoLuong,
                    DonGia = x.DichVu.DonGia,
                    ThanhTien = x.SoLuong * x.DichVu.DonGia
                }).ToList();

            danhSachSuDungDichVuDataTable.Clear();

            foreach (var row in dsDV)
            {
                danhSachSuDungDichVuDataTable.AddDanhSachSuDungDichVuRow(
                    row.ID,
                    row.DatPhongID,
                    row.DichVuID,
                    row.TenDV,
                    row.SoLuong,
                    row.DonGia,
                    row.ThanhTien
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachSuDungDichVu";
            reportDataSource.Value = danhSachSuDungDichVuDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");

            double gio = Math.Round((hoaDon.DatPhong.ThoiGianKetThuc.Value - hoaDon.DatPhong.ThoiGianBatDau).TotalHours, 3);
            decimal gia = context.Phong
                .Where(p => p.ID == hoaDon.DatPhong.PhongID)
                .Select(p => p.LoaiPhong.GiaGio)
                .FirstOrDefault();

            decimal tienHat = context.ChiTietHoaDon
                .Where(ct => ct.HoaDonID == hoaDon.ID && ct.GhiChu == "Tiền phòng")
                .Select(ct => ct.ThanhTien).FirstOrDefault();

            decimal tienDV = context.ChiTietHoaDon
                .Where(ct => ct.HoaDonID == hoaDon.ID && ct.GhiChu == "Tiền dịch vụ")
                .Select(ct => ct.ThanhTien).FirstOrDefault();

            decimal tienGiam = context.ChiTietHoaDon
                .Where(ct => ct.HoaDonID == hoaDon.ID && ct.GhiChu == "Giảm giá")
                .Select(ct => ct.ThanhTien).FirstOrDefault();

            IList<ReportParameter> param = new List<ReportParameter>
            {
            new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}",
            hoaDon.ThoiGianLap.Day,
            hoaDon.ThoiGianLap.Month,
            hoaDon.ThoiGianLap.Year)),
            new ReportParameter("NguoiLap_Ten","KARAOKE THE SCREAM"),
            new ReportParameter("NguoiLap_DiaChi", "Mỹ Phước, TP. Long Xuyên, An Giang"),
            new ReportParameter("NguoiLap_MaSoThue", "1602162070"),
            new ReportParameter("KhachHang_Ten", hoaDon.DatPhong.KhachHang.TenKH),
            new ReportParameter("KhachHang_DienThoai", hoaDon.DatPhong.KhachHang.DienThoai),
            new ReportParameter("KhachHang_MaSoThue", ""),
            new ReportParameter("TongTien", hoaDon.TongTien.ToString("N0") + " VNĐ"),
            new ReportParameter("TenPhong", hoaDon.DatPhong.Phong.TenPhong),
            new ReportParameter("GiaGio", gia.ToString("N0") + " VNĐ"),
            new ReportParameter("SoGioHat", gio.ToString()),
            new ReportParameter("TienHat", tienHat.ToString("N0") + " VNĐ"),
            new ReportParameter("TienDV", tienDV.ToString("N0") + " VNĐ"),
            new ReportParameter("TienGiam", tienGiam.ToString("N0") + " VNĐ"),
            new ReportParameter("TenKhuyenMai", hoaDon.KhuyenMai.TenKhuyenMai),
            new ReportParameter("PhanTramGiam", hoaDon.KhuyenMai.PhanTramGiam.ToString()+"%")

            };
            reportViewer1.LocalReport.SetParameters(param);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            reportViewer1.RefreshReport();

        }

        //Xác nhận thanh toán hóa đơn
        private void button1_Click(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon
                .Include(r => r.DatPhong)
                    .ThenInclude(dp => dp.KhachHang)
                .Include(r => r.DatPhong)
                    .ThenInclude(dp => dp.Phong)
                .Include(r => r.ChiTietHoaDon)
                .Include(r => r.KhuyenMai)
                .SingleOrDefault(r => r.ID == id);

            if (hoaDon == null) return;

            if (string.IsNullOrWhiteSpace(cboPhuongThuc.Text))
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var daThanhToan = context.ThanhToan
                    .Any(tt => tt.HoaDonID == hoaDon.ID);

                if (daThanhToan)
                {
                    MessageBox.Show("Hóa đơn này đã được thanh toán!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var thanhToan = new ThanhToan
                    {
                        HoaDonID = hoaDon.ID,
                        ThoiGianThanhToan = DateTime.Now,
                        PhuongThuc = cboPhuongThuc.Text,
                        SoTien = hoaDon.TongTien
                    };

                    context.ThanhToan.Add(thanhToan);
                    context.SaveChanges();

                    MessageBox.Show("Thanh toán thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
