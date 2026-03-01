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
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        QLQKDbContext context = new QLQKDbContext();
        bool xulyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenKhuyenMai.Enabled = giaTri;
            txtPhanTramGiam.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<KhuyenMai> km = new List<KhuyenMai>();
            km = context.KhuyenMai.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = km;
            txtTenKhuyenMai.DataBindings.Clear();
            txtTenKhuyenMai.DataBindings.Add("Text", bindingSource, "TenKhuyenMai", false, DataSourceUpdateMode.Never);
            txtPhanTramGiam.DataBindings.Clear();
            txtPhanTramGiam.DataBindings.Add("Text", bindingSource, "PhanTramGiam", false, DataSourceUpdateMode.Never);
            dataGridView1.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenKhuyenMai.Clear();
            txtPhanTramGiam.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhuyenMai.Text) || string.IsNullOrWhiteSpace(txtPhanTramGiam.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!decimal.TryParse(txtPhanTramGiam.Text, out decimal phantramGiam))
                {
                    MessageBox.Show("Phần trăm giảm phải là số!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (xulyThem)
                {
                    KhuyenMai km = new KhuyenMai();
                    km.TenKhuyenMai = txtTenKhuyenMai.Text;
                    km.PhanTramGiam = phantramGiam;
                    context.KhuyenMai.Add(km);
                    context.SaveChanges();
                }
                else
                {
                    KhuyenMai km = context.KhuyenMai.Find(id);
                    if (km != null)
                    {
                        km.TenKhuyenMai = txtTenKhuyenMai.Text;
                        km.PhanTramGiam = phantramGiam;
                        context.KhuyenMai.Add(km);
                        context.SaveChanges();
                    }
                }
                frmKhuyenMai_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khuyến mãi?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                KhuyenMai km = context.KhuyenMai.Find(id);
                if (km != null)
                {
                    context.KhuyenMai.Remove(km);
                }
                context.SaveChanges();
                frmKhuyenMai_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhuyenMai_Load(sender, e);
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
