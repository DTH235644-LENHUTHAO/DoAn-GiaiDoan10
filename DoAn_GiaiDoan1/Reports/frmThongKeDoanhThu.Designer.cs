namespace QuanLyQuanKaraoke.Reports
{
    partial class frmThongKeDoanhThu
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            groupBox1 = new GroupBox();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            btnHienTatCa = new Button();
            label2 = new Label();
            btnLocKetQua = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(12, 173);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1769, 719);
            reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(btnHienTatCa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLocKetQua);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1769, 144);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(808, 55);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(400, 44);
            dtpDenNgay.TabIndex = 6;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(193, 57);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(400, 44);
            dtpTuNgay.TabIndex = 5;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(1512, 48);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(235, 66);
            btnHienTatCa.TabIndex = 4;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 61);
            label2.Name = "label2";
            label2.Size = new Size(162, 36);
            label2.TabIndex = 3;
            label2.Text = "Đến ngày :";
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(1271, 48);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(235, 66);
            btnLocKetQua.TabIndex = 2;
            btnLocKetQua.Text = "Lọc kết quả 🔍";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 61);
            label1.Name = "label1";
            label1.Size = new Size(147, 36);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày :";
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1793, 904);
            Controls.Add(groupBox1);
            Controls.Add(reportViewer1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnLocKetQua;
        private DateTimePicker dtpTuNgay;
        private Button btnHienTatCa;
        private Label label2;
        private DateTimePicker dtpDenNgay;
    }
}