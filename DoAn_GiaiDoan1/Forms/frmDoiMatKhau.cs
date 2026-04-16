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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        QLQKDbContext context = new QLQKDbContext();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            var nv = context.NhanVien.Find(frmMain.NVID);

            if (nv != null)
            {
                lblTenNV.Text = nv.TenNV;
                lblTenDangNhap.Text = nv.TenDangNhap;
                lblChucVu.Text = nv.ChucVu;
                lblDienThoai.Text = nv.DienThoai;
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập !");
                Close();
            }

            // mặc định ẩn mật khẩu
            chkHienMatKhau.Checked = false;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var nv = context.NhanVien.Find(frmMain.NVID);

            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!");
                return;
            }

            // kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) ||
                string.IsNullOrWhiteSpace(txtNhapLai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // kiểm tra mật khẩu cũ
            if (!BCrypt.Net.BCrypt.Verify(txtMatKhauCu.Text, nv.MatKhau))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }


            // kiểm tra trùng mật khẩu cũ
            if (BCrypt.Net.BCrypt.Verify(txtMatKhauMoi.Text, nv.MatKhau))
            {
                MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ!");
                return;
            }

            // kiểm tra nhập lại
            if (txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác!");
                return;
            }

            // xác nhận
            var hoi = MessageBox.Show("Bạn có chắc muốn đổi mật khẩu?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (hoi == DialogResult.No) return;

            // cập nhật
            nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhauMoi.Text);
            context.NhanVien.Update(nv);
            context.SaveChanges();

            MessageBox.Show("Đổi mật khẩu thành công!", "Thành công");

            // clear form
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtNhapLai.Clear();

            txtMatKhauCu.Focus();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool hien = chkHienMatKhau.Checked;

            txtMatKhauCu.UseSystemPasswordChar = !hien;
            txtMatKhauMoi.UseSystemPasswordChar = !hien;
            txtNhapLai.UseSystemPasswordChar = !hien;
        }
    }
}
