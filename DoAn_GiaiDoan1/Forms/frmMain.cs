using DocumentFormat.OpenXml.InkML;
using QuanLyQuanKaraoke.Data;
using QuanLyQuanKaraoke.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        QLQKDbContext context = new QLQKDbContext();
        frmNhanVien nhanVien = null;
        frmKhachHang khachHang = null;
        frmDichVu dichVu = null;
        frmKhuyenMai khuyenMai = null;
        frmPhong phong = null;
        frmLoaiPhong loaiPhong = null;
        frmDangNhap dangNhap = null;
        frmDanhSachPhong danhsachPhong = null;
        frmDatPhong datPhong = null;
        frmDanhSachHoaDon danhsachhoaDon = null;
        frmThongKeDoanhThu thongKeDoanhThu = null;
        frmThongKeDichVu thongKeDichVu = null;
        frmThanhToan thanhToan = null;
        string TenNhanVien = "";
        public static int NVID = 0;
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuDichVu_Click(object sender, EventArgs e)
        {
            if (dichVu == null || dichVu.IsDisposed)
            {
                dichVu = new frmDichVu();
                dichVu.MdiParent = this;
                dichVu.Show();
            }
            else
                dichVu.Activate();
        }

        private void mnuKhuyenMai_Click(object sender, EventArgs e)
        {
            if (khuyenMai == null || khuyenMai.IsDisposed)
            {
                khuyenMai = new frmKhuyenMai();
                khuyenMai.MdiParent = this;
                khuyenMai.Show();
            }
            else
                khuyenMai.Activate();
        }

        private void mnuPhong_Click(object sender, EventArgs e)
        {
            if (phong == null || phong.IsDisposed)
            {
                phong = new frmPhong();
                phong.MdiParent = this;
                phong.Show();
            }
            else
                phong.Activate();
        }

        private void mnuLoaiPhong_Click(object sender, EventArgs e)
        {
            if (loaiPhong == null || loaiPhong.IsDisposed)
            {
                loaiPhong = new frmLoaiPhong();
                loaiPhong.MdiParent = this;
                loaiPhong.Show();
            }
            else
                loaiPhong.Activate();
        }

        private void DangNhap()
        {
            context = new QLQKDbContext();//Đăng nhập luôn cập nhật dữ liệu mới nhất
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();
            else
            {
                //reset dữ liệu
                dangNhap.txtTenDangNhap.Clear();
                dangNhap.txtMatKhau.Clear();
            }
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BCrypt.Net.BCrypt.Verify(matKhau, nhanVien.MatKhau))
                        {
                            TenNhanVien = nhanVien.TenNV;
                            NVID = nhanVien.ID;
                            if (nhanVien.ChucVu == "Quản lý")
                                QuyenQuanLy();
                            else if (nhanVien.ChucVu == "Nhân viên")
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        public void ChuaDangNhap()
        {
            // Sáng đăng nhập
            mnuDangNhap.Enabled = true;
            // Mờ tất cả
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            mnuLoaiPhong.Enabled = false;
            mnuPhong.Enabled = false;
            mnuDichVu.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuDanhSachHoaDon.Enabled = false;
            mnuThongKeDichVu.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            mnuKhuyenMai.Enabled = false;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Chưa đăng nhập.";
        }
        public void QuyenQuanLy()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Sáng đăng xuất và các chức năng quản lý được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuLoaiPhong.Enabled = true;
            mnuPhong.Enabled = true;
            mnuDichVu.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuDanhSachHoaDon.Enabled = true;
            mnuKhuyenMai.Enabled = true;
            mnuThongKeDichVu.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Quản lý: " + TenNhanVien;
        }
        public void QuyenNhanVien()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Đóng các chức năng nhân viên không được phép
            mnuLoaiPhong.Enabled = false;
            mnuPhong.Enabled = false;
            mnuDichVu.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuKhuyenMai.Enabled = true;
            // Sáng đăng xuất và các chức năng nhân viên được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuDanhSachHoaDon.Enabled = true;
            // Đóng các chức năng thống kê
            mnuThongKeDichVu.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Nhân viên: " + TenNhanVien;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();


            DangNhap();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();

        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        private void mnuDanhSachPhong_Click(object sender, EventArgs e)
        {
            if (danhsachPhong == null || danhsachPhong.IsDisposed)
            {
                danhsachPhong = new frmDanhSachPhong();
                danhsachPhong.MdiParent = this;
                danhsachPhong.Show();
            }
            else
                danhsachPhong.Activate();
        }

        private void mnuLichSuDungPhong_Click(object sender, EventArgs e)
        {
            if (datPhong == null || datPhong.IsDisposed)
            {
                datPhong = new frmDatPhong();
                datPhong.MdiParent = this;
                datPhong.Show();
            }
            else
                datPhong.Activate();
        }

        private void mnuDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            if (danhsachhoaDon == null || danhsachhoaDon.IsDisposed)
            {
                danhsachhoaDon = new frmDanhSachHoaDon();
                danhsachhoaDon.MdiParent = this;
                danhsachhoaDon.Show();
            }
            else
                danhsachhoaDon.Activate();
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null || thongKeDoanhThu.IsDisposed)
            {
                thongKeDoanhThu = new frmThongKeDoanhThu();
                thongKeDoanhThu.MdiParent = this;
                thongKeDoanhThu.Show();
            }
            else
                thongKeDoanhThu.Activate();
        }

        private void mnuThanhToan_Click(object sender, EventArgs e)
        {
            if (thanhToan == null || thanhToan.IsDisposed)
            {
                thanhToan = new frmThanhToan();
                thanhToan.MdiParent = this;
                thanhToan.Show();
            }
            else
                thanhToan.Activate();
        }

        private void mnuThongKeDichVu_Click(object sender, EventArgs e)
        {
            if (thongKeDichVu == null || thongKeDichVu.IsDisposed)
            {
                thongKeDichVu = new frmThongKeDichVu();
                thongKeDichVu.MdiParent = this;
                thongKeDichVu.Show();
            }
            else
                thongKeDichVu.Activate();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.ShowDialog();
        }
    }
}
