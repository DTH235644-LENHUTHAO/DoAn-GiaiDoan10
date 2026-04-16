namespace QuanLyQuanKaraoke.Forms
{
    partial class frmDoiMatKhau
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
            groupBox1 = new GroupBox();
            lblDienThoai = new Label();
            lblChucVu = new Label();
            lblTenDangNhap = new Label();
            lblTenNV = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chkHienMatKhau = new CheckBox();
            txtNhapLai = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtMatKhauCu = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnDoiMatKhau = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDienThoai);
            groupBox1.Controls.Add(lblChucVu);
            groupBox1.Controls.Add(lblTenDangNhap);
            groupBox1.Controls.Add(lblTenNV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1234, 393);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung ";
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(311, 297);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(97, 36);
            lblDienThoai.TabIndex = 15;
            lblDienThoai.Text = "label5";
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(311, 220);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(97, 36);
            lblChucVu.TabIndex = 14;
            lblChucVu.Text = "label5";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(311, 144);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(97, 36);
            lblTenDangNhap.TabIndex = 13;
            lblTenDangNhap.Text = "label5";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(311, 67);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(97, 36);
            lblTenNV.TabIndex = 12;
            lblTenNV.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 297);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 36);
            label4.TabIndex = 11;
            label4.Text = "📞 Điện thoại :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 220);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 36);
            label3.TabIndex = 10;
            label3.Text = "\U0001f9d1‍💼    Chức vụ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 36);
            label2.TabIndex = 9;
            label2.Text = "🔑  Tài khoản :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 36);
            label1.TabIndex = 8;
            label1.Text = "👤   Họ và tên :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkHienMatKhau);
            groupBox2.Controls.Add(txtNhapLai);
            groupBox2.Controls.Add(txtMatKhauMoi);
            groupBox2.Controls.Add(txtMatKhauCu);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(34, 452);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1235, 342);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đổi mật khẩu";
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(956, 238);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(252, 40);
            chkHienMatKhau.TabIndex = 22;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // txtNhapLai
            // 
            txtNhapLai.Location = new Point(469, 234);
            txtNhapLai.Name = "txtNhapLai";
            txtNhapLai.Size = new Size(442, 44);
            txtNhapLai.TabIndex = 21;
            txtNhapLai.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(469, 151);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(442, 44);
            txtMatKhauMoi.TabIndex = 20;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(469, 67);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(442, 44);
            txtMatKhauCu.TabIndex = 19;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 237);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(402, 36);
            label7.TabIndex = 18;
            label7.Text = "🔄️ Nhập lại mật khẩu mới  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 154);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(352, 36);
            label6.TabIndex = 17;
            label6.Text = "🆕 Nhập mật khẩu mới :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(251, 36);
            label5.TabIndex = 16;
            label5.Text = "🔐 Mật khẩu cũ :";
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Location = new Point(532, 838);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(246, 46);
            btnDoiMatKhau.TabIndex = 10;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 923);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            Load += frmDoiMatKhau_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblDienThoai;
        private Label lblChucVu;
        private Label lblTenDangNhap;
        private Label lblTenNV;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label7;
        private Label label6;
        private CheckBox chkHienMatKhau;
        private TextBox txtNhapLai;
        private TextBox txtMatKhauMoi;
        private TextBox txtMatKhauCu;
        private Button btnDoiMatKhau;
    }
}