using DoAn_GiaiDoan1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_GiaiDoan1.Forms
{
    public partial class frmDichVu : Form
    {
        public frmDichVu()
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
            txtTenDV.Enabled = giaTri;
            txtDonGia.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<DichVu> dv = new List<DichVu>();
            dv = context.DichVu.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dv;
            txtTenDV.DataBindings.Clear();
            txtTenDV.DataBindings.Add("Text", bindingSource, "TenDV", false, DataSourceUpdateMode.Never);
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);
            dataGridView1.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenDV.Clear();
            txtDonGia.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDV.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá phải là số!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (xulyThem)
                {
                    DichVu dv = new DichVu();
                    dv.TenDV = txtTenDV.Text;
                    dv.DonGia = donGia;
                    context.DichVu.Add(dv);
                    context.SaveChanges();
                }
                else
                {
                    DichVu dv = context.DichVu.Find(id);
                    if (dv != null)
                    {
                        dv.TenDV = txtTenDV.Text;
                        dv.DonGia = donGia;
                        context.DichVu.Update(dv);
                        context.SaveChanges();
                    }
                }
                frmDichVu_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa dịch vụ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                DichVu dv = context.DichVu.Find(id);
                if (dv != null)
                {
                    context.DichVu.Remove(dv);
                }
                context.SaveChanges();
                frmDichVu_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmDichVu_Load(sender, e);
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
