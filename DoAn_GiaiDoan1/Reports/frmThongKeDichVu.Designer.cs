namespace QuanLyQuanKaraoke.Reports
{
    partial class frmThongKeDichVu
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
            cboPhong = new ComboBox();
            label2 = new Label();
            btnHienTatCa = new Button();
            btnLocKetQua = new Button();
            cboDichVu = new ComboBox();
            label1 = new Label();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboPhong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnHienTatCa);
            groupBox1.Controls.Add(btnLocKetQua);
            groupBox1.Controls.Add(cboDichVu);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1704, 128);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cboPhong
            // 
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(781, 49);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(317, 44);
            cboPhong.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(606, 49);
            label2.Name = "label2";
            label2.Size = new Size(122, 36);
            label2.TabIndex = 7;
            label2.Text = "Phòng :";
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(1412, 44);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(235, 51);
            btnHienTatCa.TabIndex = 6;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(1171, 44);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(235, 51);
            btnLocKetQua.TabIndex = 5;
            btnLocKetQua.Text = "Lọc kết quả 🔍";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(236, 48);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(317, 44);
            cboDichVu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 48);
            label1.Name = "label1";
            label1.Size = new Size(140, 36);
            label1.TabIndex = 0;
            label1.Text = "Dịch vụ :";
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(23, 162);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1704, 749);
            reportViewer1.TabIndex = 1;
            // 
            // frmThongKeDichVu
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 934);
            Controls.Add(reportViewer1);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongKeDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê dịch vụ";
            Load += frmThongKeDichVu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label1;
        private ComboBox cboDichVu;
        private Button btnHienTatCa;
        private Button btnLocKetQua;
        private ComboBox cboPhong;
        private Label label2;
    }
}