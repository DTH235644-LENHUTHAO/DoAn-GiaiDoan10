using QuanLyQuanKaraoke.Data;
using QuanLyQuanKaraoke.Reports;
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
    public partial class frmDanhSachHoaDon : Form
    {
        public frmDanhSachHoaDon()
        {
            InitializeComponent();
        }
        QLQKDbContext context = new QLQKDbContext();
        int id;

        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.OrderByDescending(r => r.ThoiGianLap).Select(r => new DanhSachHoaDon
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
                XemChiTiet = "Xem chi tiết"

            }).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = hd;

            dataGridView1.DataSource = bs;

            dataGridView1.Columns["TongTien"].DefaultCellStyle.Format = "#,##0 'VNĐ'";

            //ẩn id 
            dataGridView1.Columns["NhanVienID"].Visible = false;
            dataGridView1.Columns["KhachHangID"].Visible = false;
            dataGridView1.Columns["DatPhongID"].Visible = false;
            dataGridView1.Columns["KhuyenMaiID"].Visible = false;

            //cột dãn cách theo nội dung
            dataGridView1.Columns["TenNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["TenKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["TenKhuyenMai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ThoiGianLap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["TongTien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["XemChiTiet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int hoaDonID = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                frmChiTietHoaDon f = new frmChiTietHoaDon(hoaDonID);
                f.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmDanhSachHoaDon_Load(sender, e);
        }
    }
}
