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
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }
        QLQKDbContext context = new QLQKDbContext();
        int id;

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            List<DanhSachDatPhong> dp = new List<DanhSachDatPhong>();
            dp = context.DatPhong
                .OrderBy(r => r.ThoiGianKetThuc == null ? 0 : 1) // đang hát lên trước
                .ThenByDescending(r => r.ThoiGianBatDau) // mới nhất
                .Select(r => new DanhSachDatPhong
            {
                ID = r.ID,
                PhongID = r.PhongID,
                TenPhong = r.Phong.TenPhong,
                KhachHangID = r.KhachHangID,
                TenKhachHang = r.KhachHang.TenKH,
                NhanVienID = r.NhanVienID,
                TenNhanVien = r.NhanVien.TenNV,
                ThoiGianBatDau = r.ThoiGianBatDau,
                ThoiGianKetThuc = r.ThoiGianKetThuc
            }).ToList();
            dataGridView1.DataSource = dp;


            //tự điều chỉnh kích thước cột theo nội dung
            dataGridView1.Columns["TenKhachHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["TenNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ThoiGianBatDau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ThoiGianKetThuc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Chọn 1 dòng!");
                return;
            }

            int datPhongID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

            frmHoaDon f = new frmHoaDon(datPhongID);
            f.ShowDialog();
        }
    }
}
