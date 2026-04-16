namespace QuanLyQuanKaraoke.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuPhong = new ToolStripMenuItem();
            mnuLoaiPhong = new ToolStripMenuItem();
            mnuDanhSachPhong = new ToolStripMenuItem();
            mnuDichVu = new ToolStripMenuItem();
            mnuDanhSachHoaDon = new ToolStripMenuItem();
            mnuKhuyenMai = new ToolStripMenuItem();
            mnuThanhToan = new ToolStripMenuItem();
            mnuLichSuDungPhong = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuThongKeDichVu = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, báoCáoToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1690, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, mnuThoat });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(161, 40);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(359, 44);
            mnuDangNhap.Text = "Đăng nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(359, 44);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(359, 44);
            mnuDoiMatKhau.Text = "Đổi mật khẩu";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(359, 44);
            mnuThoat.Text = "Thoát";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuNhanVien, mnuKhachHang, mnuPhong, mnuLoaiPhong, mnuDanhSachPhong, mnuDichVu, mnuDanhSachHoaDon, mnuKhuyenMai, mnuThanhToan, mnuLichSuDungPhong });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(144, 40);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(505, 44);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(505, 44);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuPhong
            // 
            mnuPhong.Name = "mnuPhong";
            mnuPhong.Size = new Size(505, 44);
            mnuPhong.Text = "Phòng";
            mnuPhong.Click += mnuPhong_Click;
            // 
            // mnuLoaiPhong
            // 
            mnuLoaiPhong.Name = "mnuLoaiPhong";
            mnuLoaiPhong.Size = new Size(505, 44);
            mnuLoaiPhong.Text = "Loại phòng";
            mnuLoaiPhong.Click += mnuLoaiPhong_Click;
            // 
            // mnuDanhSachPhong
            // 
            mnuDanhSachPhong.Name = "mnuDanhSachPhong";
            mnuDanhSachPhong.Size = new Size(505, 44);
            mnuDanhSachPhong.Text = "Danh sách phòng";
            mnuDanhSachPhong.Click += mnuDanhSachPhong_Click;
            // 
            // mnuDichVu
            // 
            mnuDichVu.Name = "mnuDichVu";
            mnuDichVu.Size = new Size(505, 44);
            mnuDichVu.Text = "Dịch vụ";
            mnuDichVu.Click += mnuDichVu_Click;
            // 
            // mnuDanhSachHoaDon
            // 
            mnuDanhSachHoaDon.Name = "mnuDanhSachHoaDon";
            mnuDanhSachHoaDon.Size = new Size(505, 44);
            mnuDanhSachHoaDon.Text = "Danh sách hóa đơn đã lập";
            mnuDanhSachHoaDon.Click += mnuDanhSachHoaDon_Click;
            // 
            // mnuKhuyenMai
            // 
            mnuKhuyenMai.Name = "mnuKhuyenMai";
            mnuKhuyenMai.Size = new Size(505, 44);
            mnuKhuyenMai.Text = "Khuyến mãi";
            mnuKhuyenMai.Click += mnuKhuyenMai_Click;
            // 
            // mnuThanhToan
            // 
            mnuThanhToan.Name = "mnuThanhToan";
            mnuThanhToan.Size = new Size(505, 44);
            mnuThanhToan.Text = "Thanh toán";
            mnuThanhToan.Click += mnuThanhToan_Click;
            // 
            // mnuLichSuDungPhong
            // 
            mnuLichSuDungPhong.Name = "mnuLichSuDungPhong";
            mnuLichSuDungPhong.Size = new Size(505, 44);
            mnuLichSuDungPhong.Text = "Lập hóa đơn";
            mnuLichSuDungPhong.Click += mnuLichSuDungPhong_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeDoanhThu, mnuThongKeDichVu });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(297, 40);
            báoCáoToolStripMenuItem.Text = "Báo cáo - Thống kê";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(426, 44);
            mnuThongKeDoanhThu.Text = "Thống kê doanh thu";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuThongKeDichVu
            // 
            mnuThongKeDichVu.Name = "mnuThongKeDichVu";
            mnuThongKeDichVu.Size = new Size(426, 44);
            mnuThongKeDichVu.Text = "Thống kê dịch vụ";
            mnuThongKeDichVu.Click += mnuThongKeDichVu_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hướngDẫnSửDụngToolStripMenuItem, thôngTinPhầnMềmToolStripMenuItem });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(155, 40);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(438, 44);
            hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            thôngTinPhầnMềmToolStripMenuItem.Size = new Size(438, 44);
            thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4, lblLienKet });
            statusStrip1.Location = new Point(0, 902);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1690, 42);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(191, 32);
            lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 32);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(0, 32);
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(1352, 32);
            toolStripStatusLabel4.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(132, 32);
            lblLienKet.Text = "© 2024 FIT";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1690, 944);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý quán Karaoke";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuPhong;
        private ToolStripMenuItem mnuLoaiPhong;
        private ToolStripMenuItem mnuDanhSachPhong;
        private ToolStripMenuItem mnuDichVu;
        private ToolStripMenuItem mnuDanhSachHoaDon;
        private ToolStripMenuItem mnuKhuyenMai;
        private ToolStripMenuItem mnuThanhToan;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuThongKeDichVu;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripMenuItem mnuLichSuDungPhong;
    }
}