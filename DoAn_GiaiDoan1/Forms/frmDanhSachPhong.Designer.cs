namespace QuanLyQuanKaraoke.Forms
{
    partial class frmDanhSachPhong
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
            groupBox2 = new GroupBox();
            panelPhong = new FlowLayoutPanel();
            btnReset = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelPhong);
            groupBox2.Location = new Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1381, 699);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng";
            // 
            // panelPhong
            // 
            panelPhong.AutoScroll = true;
            panelPhong.Dock = DockStyle.Fill;
            panelPhong.Location = new Point(3, 40);
            panelPhong.Name = "panelPhong";
            panelPhong.Size = new Size(1375, 656);
            panelPhong.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonFace;
            btnReset.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnReset.ForeColor = Color.Green;
            btnReset.Location = new Point(1276, 45);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(117, 70);
            btnReset.TabIndex = 3;
            btnReset.Text = "🔄️";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmDanhSachPhong
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 856);
            Controls.Add(btnReset);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDanhSachPhong";
            Text = "Danh sách phòng";
            Load += frmDanhSachPhong_Load;
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private FlowLayoutPanel panelPhong;
        private Button btnReset;
    }
}