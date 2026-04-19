namespace QuanLyQuanKaraoke.Forms
{
    partial class frmThongTinPhanMem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinPhanMem));
            pictureBox1 = new PictureBox();
            lblTenPM = new Label();
            lblVersion = new Label();
            lblTacGia = new Label();
            lblLop = new Label();
            lblGiaoVien = new Label();
            lblEmail = new Label();
            lblSoDienThoai = new Label();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MediumTurquoise;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTenPM
            // 
            lblTenPM.AutoSize = true;
            lblTenPM.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTenPM.Location = new Point(535, 55);
            lblTenPM.Name = "lblTenPM";
            lblTenPM.Size = new Size(113, 42);
            lblTenPM.TabIndex = 1;
            lblTenPM.Text = "label1";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblVersion.Location = new Point(484, 156);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(93, 36);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "label1";
            // 
            // lblTacGia
            // 
            lblTacGia.AutoSize = true;
            lblTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTacGia.Location = new Point(484, 233);
            lblTacGia.Name = "lblTacGia";
            lblTacGia.Size = new Size(93, 36);
            lblTacGia.TabIndex = 3;
            lblTacGia.Text = "label1";
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblLop.Location = new Point(484, 313);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(93, 36);
            lblLop.TabIndex = 4;
            lblLop.Text = "label1";
            // 
            // lblGiaoVien
            // 
            lblGiaoVien.AutoSize = true;
            lblGiaoVien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblGiaoVien.Location = new Point(484, 395);
            lblGiaoVien.Name = "lblGiaoVien";
            lblGiaoVien.Size = new Size(93, 36);
            lblGiaoVien.TabIndex = 5;
            lblGiaoVien.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblEmail.Location = new Point(484, 481);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(93, 36);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "label1";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblSoDienThoai.Location = new Point(484, 570);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(93, 36);
            lblSoDienThoai.TabIndex = 7;
            lblSoDienThoai.Text = "label1";
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.FromArgb(192, 0, 0);
            btnThoat.Location = new Point(1458, 570);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmThongTinPhanMem
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1662, 652);
            Controls.Add(btnThoat);
            Controls.Add(lblSoDienThoai);
            Controls.Add(lblEmail);
            Controls.Add(lblGiaoVien);
            Controls.Add(lblLop);
            Controls.Add(lblTacGia);
            Controls.Add(lblVersion);
            Controls.Add(lblTenPM);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongTinPhanMem";
            Text = "Thông tin phần mềm";
            Load += frmThongTinPhanMem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTenPM;
        private Label lblVersion;
        private Label lblTacGia;
        private Label lblLop;
        private Label lblGiaoVien;
        private Label lblEmail;
        private Label lblSoDienThoai;
        private Button btnThoat;
    }
}