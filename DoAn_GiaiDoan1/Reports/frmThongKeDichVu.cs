using Microsoft.Reporting.WinForms;
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
using static QuanLyQuanKaraoke.Reports.QLQKDataSet;

namespace QuanLyQuanKaraoke.Reports
{
    public partial class frmThongKeDichVu : Form
    {
        QLQKDbContext context = new QLQKDbContext();
        QLQKDataSet.DanhSachDichVuThongKeDataTable danhSachDichVuThongKeDataTable = new QLQKDataSet.DanhSachDichVuThongKeDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        public frmThongKeDichVu()
        {
            InitializeComponent();
        }

        public void LayDichVuVaoComboBox()
        {
            
            cboDichVu.DataSource = context.DichVu.ToList();
            cboDichVu.DisplayMember = "TenDV";
            cboDichVu.ValueMember = "ID";

            cboDichVu.SelectedIndex = -1;

        }

        public void LayPhongVaoComboBox()
        {
           

            cboPhong.DataSource = context.Phong.ToList();
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "ID";

            cboPhong.SelectedIndex = -1;

        }

        private void frmThongKeDichVu_Load(object sender, EventArgs e)
        {
            LayDichVuVaoComboBox();
            LayPhongVaoComboBox();

            var danhSachDichVuThongKe = context.SuDungDichVu.Select(r => new DanhSachSuDungDichVuThongKe
            {
                ID = r.ID,

                DatPhongID = r.DatPhongID,
                TenPhong = r.DatPhong.Phong.TenPhong,
                DichVuID = r.DichVuID,
                TenDV = r.DichVu.TenDV,
                SoLuong = r.SoLuong,
                DonGia = r.DichVu.DonGia,
                ThanhTien = r.SoLuong * r.DichVu.DonGia

            }).ToList();

            danhSachDichVuThongKeDataTable.Clear();
            foreach (var row in danhSachDichVuThongKe)
            {
                danhSachDichVuThongKeDataTable.AddDanhSachDichVuThongKeRow(
                row.ID,
                row.DatPhongID,
                row.DichVuID,
                row.TenPhong,
                row.TenDV,
                row.SoLuong,
                row.DonGia,
                row.ThanhTien
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachDichVuThongKe";
            reportDataSource.Value = danhSachDichVuThongKeDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDichVu.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả sản phẩm)");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            reportViewer1.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            if (cboDichVu.Text == "" && cboPhong.Text == "")
            {
                // Nếu cả 2 ComboBox đều bỏ trống thì hiển thị tất cả
                frmThongKeDichVu_Load(sender, e);
            }
            else
            {
                var danhSachDichVuThongKe = context.SuDungDichVu.Select(r => new DanhSachSuDungDichVuThongKe
                {
                    ID = r.ID,

                    DatPhongID = r.DatPhongID,
                    TenPhong = r.DatPhong.Phong.TenPhong,
                    DichVuID = r.DichVuID,
                    TenDV = r.DichVu.TenDV,
                    SoLuong = r.SoLuong,
                    DonGia = r.DichVu.DonGia,
                    ThanhTien = r.SoLuong * r.DichVu.DonGia

                });
                string dichVu = null;
                string phong = null;
                if (cboDichVu.Text != "")
                {
                    int dichVuID = Convert.ToInt32(cboDichVu.SelectedValue.ToString());
                    dichVu = "Dịch vụ: " + cboDichVu.Text;
                    danhSachDichVuThongKe = danhSachDichVuThongKe.Where(r => r.DichVuID == dichVuID);
                }
                if (cboPhong.Text != "")
                {
                    phong += "Phân loại: " + cboPhong.Text;
                    danhSachDichVuThongKe = danhSachDichVuThongKe.Where(r => r.TenPhong.Trim() == cboPhong.Text.Trim());
                }
                danhSachDichVuThongKeDataTable.Clear();
                foreach (var row in danhSachDichVuThongKe)
                {

                    danhSachDichVuThongKeDataTable.AddDanhSachDichVuThongKeRow(
                    row.ID,
                    row.DatPhongID,
                    row.DichVuID,
                    row.TenPhong,
                    row.TenDV,
                    row.SoLuong,
                    row.DonGia,
                    row.ThanhTien
                    );

                }
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachDichVuThongKe";
                reportDataSource.Value = danhSachDichVuThongKeDataTable;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDichVu.rdlc");

                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(" + phong + " - " + dichVu + ")");
                reportViewer1.LocalReport.SetParameters(reportParameter);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDichVu_Load(sender, e);
        }
    }
}
