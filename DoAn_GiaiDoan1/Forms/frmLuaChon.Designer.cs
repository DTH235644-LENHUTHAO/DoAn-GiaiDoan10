namespace QuanLyQuanKaraoke.Forms
{
    partial class frmLuaChon
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
            btnDongPhong = new Button();
            btnThemDV = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // btnDongPhong
            // 
            btnDongPhong.ForeColor = Color.Red;
            btnDongPhong.Location = new Point(87, 111);
            btnDongPhong.Name = "btnDongPhong";
            btnDongPhong.Size = new Size(264, 93);
            btnDongPhong.TabIndex = 0;
            btnDongPhong.Text = "🎤 Đóng phòng";
            btnDongPhong.UseVisualStyleBackColor = true;
            btnDongPhong.Click += btnDongPhong_Click;
            // 
            // btnThemDV
            // 
            btnThemDV.ForeColor = Color.FromArgb(0, 192, 0);
            btnThemDV.Location = new Point(376, 111);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(264, 93);
            btnThemDV.TabIndex = 1;
            btnThemDV.Text = "\U0001f964 Thêm dịch vụ";
            btnThemDV.UseVisualStyleBackColor = true;
            btnThemDV.Click += btnThemDV_Click;
            // 
            // btnHuy
            // 
            btnHuy.ForeColor = Color.FromArgb(64, 64, 64);
            btnHuy.Location = new Point(667, 111);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(264, 93);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "❌ Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmLuaChon
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 315);
            Controls.Add(btnHuy);
            Controls.Add(btnThemDV);
            Controls.Add(btnDongPhong);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLuaChon";
            Text = "Chọn chức năng";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDongPhong;
        private Button btnThemDV;
        private Button btnHuy;
    }
}