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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }
        QLQKDbContext context = new QLQKDbContext();
        int id;

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            var dsThanhToan = context.ThanhToan
                .Select(tt => new
                {
                    tt.ID,
                    tt.HoaDonID,
                    tt.ThoiGianThanhToan,
                    tt.PhuongThuc,
                    tt.SoTien
                })
                .ToList();


            BindingSource bs = new BindingSource();
            bs.DataSource = dsThanhToan;

            dataGridView1.DataSource = bs;

            dataGridView1.Columns["SoTien"].DefaultCellStyle.Format = "#,##0 'VNĐ'";


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
