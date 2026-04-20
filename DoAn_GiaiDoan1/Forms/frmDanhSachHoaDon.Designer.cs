namespace QuanLyQuanKaraoke.Forms
{
    partial class frmDanhSachHoaDon
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
            btnReset = new Button();
            btnInHoaDon = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            DatPhongID = new DataGridViewTextBoxColumn();
            PhongID = new DataGridViewTextBoxColumn();
            TenPhong = new DataGridViewTextBoxColumn();
            NhanVienID = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            KhachHangID = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            KhuyenMaiID = new DataGridViewTextBoxColumn();
            TenKhuyenMai = new DataGridViewTextBoxColumn();
            ThoiGianLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnInHoaDon);
            groupBox1.Location = new Point(25, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2435, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonFace;
            btnReset.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnReset.ForeColor = Color.Green;
            btnReset.Location = new Point(2316, 43);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(117, 70);
            btnReset.TabIndex = 5;
            btnReset.Text = "🔄️";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.ForeColor = Color.FromArgb(0, 192, 0);
            btnInHoaDon.Location = new Point(2048, 43);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(252, 70);
            btnInHoaDon.TabIndex = 0;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(23, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2440, 817);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn đã lập";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, DatPhongID, PhongID, TenPhong, NhanVienID, TenNV, KhachHangID, TenKH, KhuyenMaiID, TenKhuyenMai, ThoiGianLap, TongTien, XemChiTiet });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(2434, 774);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            // 
            // DatPhongID
            // 
            DatPhongID.DataPropertyName = "DatPhongID";
            DatPhongID.HeaderText = "ID đặt phòng";
            DatPhongID.MinimumWidth = 10;
            DatPhongID.Name = "DatPhongID";
            // 
            // PhongID
            // 
            PhongID.DataPropertyName = "PhongID";
            PhongID.HeaderText = "ID phòng";
            PhongID.MinimumWidth = 10;
            PhongID.Name = "PhongID";
            // 
            // TenPhong
            // 
            TenPhong.DataPropertyName = "TenPhong";
            TenPhong.HeaderText = "Tên phòng";
            TenPhong.MinimumWidth = 10;
            TenPhong.Name = "TenPhong";
            // 
            // NhanVienID
            // 
            NhanVienID.DataPropertyName = "NhanVienID";
            NhanVienID.HeaderText = "ID nhân viên";
            NhanVienID.MinimumWidth = 10;
            NhanVienID.Name = "NhanVienID";
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Tên nhân viên";
            TenNV.MinimumWidth = 10;
            TenNV.Name = "TenNV";
            // 
            // KhachHangID
            // 
            KhachHangID.DataPropertyName = "KhachHangID";
            KhachHangID.HeaderText = "ID khách hàng";
            KhachHangID.MinimumWidth = 10;
            KhachHangID.Name = "KhachHangID";
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.MinimumWidth = 10;
            TenKH.Name = "TenKH";
            // 
            // KhuyenMaiID
            // 
            KhuyenMaiID.DataPropertyName = "KhuyenMaiID";
            KhuyenMaiID.HeaderText = "ID khuyến mãi";
            KhuyenMaiID.MinimumWidth = 10;
            KhuyenMaiID.Name = "KhuyenMaiID";
            // 
            // TenKhuyenMai
            // 
            TenKhuyenMai.DataPropertyName = "TenKhuyenMai";
            TenKhuyenMai.HeaderText = "Tên khuyến mãi";
            TenKhuyenMai.MinimumWidth = 10;
            TenKhuyenMai.Name = "TenKhuyenMai";
            // 
            // ThoiGianLap
            // 
            ThoiGianLap.DataPropertyName = "ThoiGianLap";
            ThoiGianLap.HeaderText = "Thời gian lập";
            ThoiGianLap.MinimumWidth = 10;
            ThoiGianLap.Name = "ThoiGianLap";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 10;
            TongTien.Name = "TongTien";
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 10;
            XemChiTiet.Name = "XemChiTiet";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmDanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2498, 1028);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDanhSachHoaDon";
            Text = "Danh sách hóa đơn";
            Load += frmDanhSachHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DatPhongID;
        private DataGridViewTextBoxColumn PhongID;
        private DataGridViewTextBoxColumn TenPhong;
        private DataGridViewTextBoxColumn NhanVienID;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn KhachHangID;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn KhuyenMaiID;
        private DataGridViewTextBoxColumn TenKhuyenMai;
        private DataGridViewTextBoxColumn ThoiGianLap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewLinkColumn XemChiTiet;
        private Button btnInHoaDon;
        private Button btnReset;
    }
}