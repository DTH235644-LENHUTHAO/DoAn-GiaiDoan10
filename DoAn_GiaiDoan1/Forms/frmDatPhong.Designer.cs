namespace QuanLyQuanKaraoke.Forms
{
    partial class frmDatPhong
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PhongID = new DataGridViewTextBoxColumn();
            TenPhong = new DataGridViewTextBoxColumn();
            KhachHangID = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            NhanVienID = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            ThoiGianBatDau = new DataGridViewTextBoxColumn();
            ThoiGianKetThuc = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnLapHoaDon = new Button();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(22, 247);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1955, 759);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lịch sử dùng phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, PhongID, TenPhong, KhachHangID, TenKhachHang, NhanVienID, TenNhanVien, ThoiGianBatDau, ThoiGianKetThuc });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 41);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1947, 714);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
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
            // KhachHangID
            // 
            KhachHangID.DataPropertyName = "KhachHangID";
            KhachHangID.HeaderText = "ID khách hàng";
            KhachHangID.MinimumWidth = 10;
            KhachHangID.Name = "KhachHangID";
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên khách hàng";
            TenKhachHang.MinimumWidth = 10;
            TenKhachHang.Name = "TenKhachHang";
            // 
            // NhanVienID
            // 
            NhanVienID.DataPropertyName = "NhanVienID";
            NhanVienID.HeaderText = "ID nhân viên";
            NhanVienID.MinimumWidth = 10;
            NhanVienID.Name = "NhanVienID";
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên nhân viên";
            TenNhanVien.MinimumWidth = 10;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // ThoiGianBatDau
            // 
            ThoiGianBatDau.DataPropertyName = "ThoiGianBatDau";
            ThoiGianBatDau.HeaderText = "Thời gian bắt đầu";
            ThoiGianBatDau.MinimumWidth = 10;
            ThoiGianBatDau.Name = "ThoiGianBatDau";
            // 
            // ThoiGianKetThuc
            // 
            ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
            ThoiGianKetThuc.HeaderText = "Thời gian kết thúc";
            ThoiGianKetThuc.MinimumWidth = 10;
            ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnLapHoaDon);
            groupBox2.Location = new Point(22, 19);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1951, 189);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.ForeColor = Color.Green;
            btnLapHoaDon.Location = new Point(1580, 67);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(225, 67);
            btnLapHoaDon.TabIndex = 0;
            btnLapHoaDon.Text = "Lập hóa đơn";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonFace;
            btnReset.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnReset.ForeColor = Color.Green;
            btnReset.Location = new Point(1838, 64);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(117, 70);
            btnReset.TabIndex = 4;
            btnReset.Text = "🔄️";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmDatPhong
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2005, 1022);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDatPhong";
            Text = "Phòng đã mở ";
            Load += frmDatPhong_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PhongID;
        private DataGridViewTextBoxColumn TenPhong;
        private DataGridViewTextBoxColumn KhachHangID;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn NhanVienID;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn ThoiGianBatDau;
        private DataGridViewTextBoxColumn ThoiGianKetThuc;
        private Button btnLapHoaDon;
        private Button btnReset;
    }
}