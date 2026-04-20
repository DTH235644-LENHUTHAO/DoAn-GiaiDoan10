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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
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
            txtTenLoaiPhong.Enabled = giaTri;
            txtSucChua.Enabled = giaTri;
            txtGiaGio.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<LoaiPhong> lp = new List<LoaiPhong>();
            lp = context.LoaiPhong.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lp;
            txtTenLoaiPhong.DataBindings.Clear();
            txtTenLoaiPhong.DataBindings.Add("Text", bindingSource, "TenLoaiPhong", false, DataSourceUpdateMode.Never);
            txtSucChua.DataBindings.Clear();
            txtSucChua.DataBindings.Add("Text", bindingSource, "SucChua", false, DataSourceUpdateMode.Never);
            txtGiaGio.DataBindings.Clear();
            txtGiaGio.DataBindings.Add("Text", bindingSource, "GiaGio", false, DataSourceUpdateMode.Never);
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Columns["GiaGio"].DefaultCellStyle.Format = "#,##0 'VNĐ'";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenLoaiPhong.Clear();
            txtSucChua.Clear();
            txtGiaGio.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiPhong.Text) || string.IsNullOrWhiteSpace(txtSucChua.Text) || string.IsNullOrWhiteSpace(txtGiaGio.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!decimal.TryParse(txtGiaGio.Text, out decimal giaGio))
                {
                    MessageBox.Show("Phần trăm giảm phải là số!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (xulyThem)
                {
                    LoaiPhong lp = new LoaiPhong();
                    lp.TenLoaiPhong = txtTenLoaiPhong.Text;
                    lp.SucChua = int.Parse(txtSucChua.Text);
                    lp.GiaGio = giaGio;
                    context.LoaiPhong.Add(lp);
                    context.SaveChanges();
                }
                else
                {
                    LoaiPhong lp = context.LoaiPhong.Find(id);
                    if (lp != null)
                    {
                        lp.TenLoaiPhong = txtTenLoaiPhong.Text;
                        lp.SucChua = int.Parse(txtSucChua.Text);
                        lp.GiaGio = giaGio;
                        context.LoaiPhong.Add(lp);
                        context.SaveChanges();
                    }
                }
                frmLoaiPhong_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại phòng?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                LoaiPhong lp = context.LoaiPhong.Find(id);
                if (lp != null)
                {
                    context.LoaiPhong.Remove(lp);
                }
                context.SaveChanges();
                frmLoaiPhong_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiPhong_Load(sender, e);
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
