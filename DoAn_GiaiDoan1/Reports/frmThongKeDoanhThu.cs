using Microsoft.Reporting.WinForms;
using QuanLyQuanKaraoke.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLQKDbContext context = new QLQKDbContext();
        QLQKDataSet.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLQKDataSet.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }



        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {


            var danhSachHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,

                PhongID = r.DatPhong.PhongID,
                TenPhong = r.DatPhong.Phong.TenPhong,


                KhachHangID = r.DatPhong.KhachHangID,
                TenKH = r.DatPhong.KhachHang.TenKH,

                ThoiGianLap = r.ThoiGianLap,
                TongTien = r.TongTien,

            }).ToList();



            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                row.ID,
                row.PhongID,
                row.TenPhong,
                row.KhachHangID,
                row.TenKH,
                row.ThoiGianLap,
                row.TongTien);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            // Mô tả kết quả hiển thị trên báo cáo
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả thời gian)");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            reportViewer1.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,

                PhongID = r.DatPhong.PhongID,
                TenPhong = r.DatPhong.Phong.TenPhong,


                KhachHangID = r.DatPhong.KhachHangID,
                TenKH = r.DatPhong.KhachHang.TenKH,

                ThoiGianLap = r.ThoiGianLap,
                TongTien = r.TongTien,

            }).ToList();

            danhSachHoaDon = danhSachHoaDon.Where(r => r.ThoiGianLap >= dtpTuNgay.Value && r.ThoiGianLap <= dtpDenNgay.Value).ToList();

            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                row.ID,
                row.PhongID,
                row.TenPhong,
                row.KhachHangID,
                row.TenKH,
                row.ThoiGianLap,
                row.TongTien);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            // Mô tả kết quả hiển thị trên báo cáo
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "Từ ngày " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text);
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            reportViewer1.RefreshReport();
        }
    }
}
