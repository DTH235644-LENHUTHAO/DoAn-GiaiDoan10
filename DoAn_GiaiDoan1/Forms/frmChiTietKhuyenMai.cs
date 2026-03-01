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
    public partial class frmChiTietKhuyenMai : Form
    {
        public frmChiTietKhuyenMai()
        {
            InitializeComponent();
        }

        QLQKDbContext context = new QLQKDbContext();
        bool xulyThem = false;
        int id;
        BindingList<DanhSachChiTietKhuyenMai> chitietKhuyenMai = new BindingList<DanhSachChiTietKhuyenMai>();

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboKhuyenMai.Enabled = giaTri;
            txtGhiChu.Enabled = giaTri;
            dateTimePicker1.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;

        }
        private void frmChiTietKhuyenMai_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayKhuyenMaiVaoComboBox();
            dataGridView1.AutoGenerateColumns = false;
            if (id != 0)
            {
                var khuyenMai = context.KhuyenMai.Where(ctkm => ctkm.ID == id).SingleOrDefault();
                cboKhuyenMai.SelectedValue = khuyenMai.ID;

                var ds = context.ChiTietKhuyenMai.Where(ctkm => ctkm.KhuyenMaiID == id)
                    .Select(ctkm => new DanhSachChiTietKhuyenMai

                    {
                        ID = ctkm.ID,
                        TenKhuyenMai = ctkm.KhuyenMai.TenKhuyenMai,
                        PhanTramGiam = ctkm.KhuyenMai.PhanTramGiam,
                        GhiChu = ctkm.GhiChu,
                        ThoiDiemApDung = ctkm.ThoiDiemApDung
                    }).ToList();
                chitietKhuyenMai = new BindingList<DanhSachChiTietKhuyenMai>(ds);
            }
            dataGridView1.DataSource = chitietKhuyenMai;

        }

        public void LayKhuyenMaiVaoComboBox()
        {
            cboKhuyenMai.DataSource = context.KhuyenMai.ToList();
            cboKhuyenMai.DisplayMember = "TenKhuyenMai";
            cboKhuyenMai.ValueMember = "ID";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            cboKhuyenMai.SelectedValue = -1;
            txtGhiChu.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa chi tiết khuyến mãi?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                ChiTietKhuyenMai ctkm = context.ChiTietKhuyenMai.Find(id);
                if (ctkm != null)
                {
                    context.ChiTietKhuyenMai.Remove(ctkm);
                }
                context.SaveChanges();
                frmChiTietKhuyenMai_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboKhuyenMai.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                if (xulyThem)
                {
                    ChiTietKhuyenMai ctkm = new ChiTietKhuyenMai();
                    ctkm.ThoiDiemApDung = dateTimePicker1.Value;
                    ctkm.GhiChu = txtGhiChu.Text;
                    ctkm.KhuyenMaiID = (int)cboKhuyenMai.SelectedValue;
                    context.ChiTietKhuyenMai.Add(ctkm);
                    context.SaveChanges();
                }
                else
                {
                    ChiTietKhuyenMai ctkm = context.ChiTietKhuyenMai.Find(id);
                    if (ctkm != null)
                    {

                        ctkm.ThoiDiemApDung = dateTimePicker1.Value;
                        ctkm.GhiChu = txtGhiChu.Text;
                        ctkm.KhuyenMaiID = (int)cboKhuyenMai.SelectedValue;
                        context.ChiTietKhuyenMai.Add(ctkm);
                        context.SaveChanges();
                    }
                }
                frmChiTietKhuyenMai_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmChiTietKhuyenMai_Load(sender, e);
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
