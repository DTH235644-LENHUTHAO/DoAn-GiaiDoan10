namespace QuanLyQuanKaraoke.Forms
{
    partial class frmMoPhong
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
            lblPhong = new Label();
            lblNhanVien = new Label();
            btnMoPhong = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTenKH = new TextBox();
            txtDienThoai = new TextBox();
            SuspendLayout();
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPhong.ForeColor = Color.FromArgb(0, 0, 192);
            lblPhong.Location = new Point(45, 45);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(244, 55);
            lblPhong.TabIndex = 0;
            lblPhong.Text = "Tên Phòng";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(40, 172);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(190, 31);
            lblNhanVien.TabIndex = 1;
            lblNhanVien.Text = "Tên Nhân Viên";
            // 
            // btnMoPhong
            // 
            btnMoPhong.Location = new Point(1327, 90);
            btnMoPhong.Name = "btnMoPhong";
            btnMoPhong.Size = new Size(184, 45);
            btnMoPhong.TabIndex = 4;
            btnMoPhong.Text = "Mở phòng";
            btnMoPhong.UseVisualStyleBackColor = true;
            btnMoPhong.Click += btnMoPhong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 65);
            label1.Name = "label1";
            label1.Size = new Size(217, 31);
            label1.TabIndex = 5;
            label1.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(616, 138);
            label2.Name = "label2";
            label2.Size = new Size(183, 31);
            label2.TabIndex = 6;
            label2.Text = "Số điện thoại :";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(851, 57);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(356, 39);
            txtTenKH.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(851, 130);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(356, 39);
            txtDienThoai.TabIndex = 8;
            // 
            // frmMoPhong
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 228);
            Controls.Add(txtDienThoai);
            Controls.Add(txtTenKH);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMoPhong);
            Controls.Add(lblNhanVien);
            Controls.Add(lblPhong);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Name = "frmMoPhong";
            Text = "Mở phòng";
            Load += frmDatPhong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhong;
        private Label lblNhanVien;
        private Button btnMoPhong;
        private Label label1;
        private Label label2;
        private TextBox txtTenKH;
        private TextBox txtDienThoai;
    }
}