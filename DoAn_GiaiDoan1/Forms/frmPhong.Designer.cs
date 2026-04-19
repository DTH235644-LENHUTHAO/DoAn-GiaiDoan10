namespace QuanLyQuanKaraoke.Forms
{
    partial class frmPhong
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label4 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenPhong = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            IDPhong = new DataGridViewTextBoxColumn();
            TenPhong = new DataGridViewTextBoxColumn();
            TenLoaiPhong = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            SucChua = new DataGridViewTextBoxColumn();
            GiaGio = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            btnKichHoat = new Button();
            cboTrangThai = new ComboBox();
            btnThemAnh = new Button();
            btnDoiHinh = new Button();
            picHinhAnh = new PictureBox();
            cboLoaiPhong = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 275);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(179, 36);
            label4.TabIndex = 12;
            label4.Text = "Trạng thái :";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1750, 404);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(237, 55);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1476, 405);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(237, 55);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.DeepSkyBlue;
            btnLuu.Location = new Point(1206, 405);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(237, 55);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(617, 404);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(275, 55);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Ngưng hoạt động";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(349, 403);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(237, 55);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.ForeColor = Color.FromArgb(0, 192, 0);
            btnThem.Location = new Point(84, 404);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(237, 55);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(378, 58);
            txtTenPhong.Margin = new Padding(4);
            txtTenPhong.Multiline = true;
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(556, 50);
            txtTenPhong.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 281);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 36);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 174);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 36);
            label2.TabIndex = 1;
            label2.Text = "Loại phòng :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 36);
            label1.TabIndex = 0;
            label1.Text = "Tên phòng :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(26, 570);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2070, 722);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khuyến mãi";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDPhong, TenPhong, TenLoaiPhong, TrangThai, SucChua, GiaGio, HinhAnh });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(2064, 679);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // IDPhong
            // 
            IDPhong.DataPropertyName = "ID";
            IDPhong.HeaderText = "IDPhong";
            IDPhong.MinimumWidth = 10;
            IDPhong.Name = "IDPhong";
            // 
            // TenPhong
            // 
            TenPhong.DataPropertyName = "TenPhong";
            TenPhong.HeaderText = "Tên phòng";
            TenPhong.MinimumWidth = 10;
            TenPhong.Name = "TenPhong";
            // 
            // TenLoaiPhong
            // 
            TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            TenLoaiPhong.HeaderText = "Loại phòng";
            TenLoaiPhong.MinimumWidth = 10;
            TenLoaiPhong.Name = "TenLoaiPhong";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 10;
            TrangThai.Name = "TrangThai";
            // 
            // SucChua
            // 
            SucChua.DataPropertyName = "SucChua";
            SucChua.HeaderText = "Sức chứa";
            SucChua.MinimumWidth = 10;
            SucChua.Name = "SucChua";
            // 
            // GiaGio
            // 
            GiaGio.DataPropertyName = "GiaGio";
            GiaGio.HeaderText = "Giá giờ";
            GiaGio.MinimumWidth = 10;
            GiaGio.Name = "GiaGio";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 10;
            HinhAnh.Name = "HinhAnh";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKichHoat);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(btnThemAnh);
            groupBox1.Controls.Add(btnDoiHinh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(cboLoaiPhong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenPhong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 21);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(2067, 512);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // btnKichHoat
            // 
            btnKichHoat.ForeColor = Color.Blue;
            btnKichHoat.Location = new Point(928, 404);
            btnKichHoat.Name = "btnKichHoat";
            btnKichHoat.Size = new Size(237, 55);
            btnKichHoat.TabIndex = 19;
            btnKichHoat.Text = "Kích hoạt";
            btnKichHoat.UseVisualStyleBackColor = true;
            btnKichHoat.Click += btnKichHoat_Click_1;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Bình thường", "Bảo trì" });
            cboTrangThai.Location = new Point(378, 272);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(556, 44);
            cboTrangThai.TabIndex = 18;
            // 
            // btnThemAnh
            // 
            btnThemAnh.Location = new Point(1645, 134);
            btnThemAnh.Name = "btnThemAnh";
            btnThemAnh.Size = new Size(166, 55);
            btnThemAnh.TabIndex = 17;
            btnThemAnh.Text = "Thêm ảnh";
            btnThemAnh.UseVisualStyleBackColor = true;
            btnThemAnh.Click += btnThemAnh_Click;
            // 
            // btnDoiHinh
            // 
            btnDoiHinh.Location = new Point(1645, 58);
            btnDoiHinh.Name = "btnDoiHinh";
            btnDoiHinh.Size = new Size(166, 55);
            btnDoiHinh.TabIndex = 16;
            btnDoiHinh.Text = "Đổi";
            btnDoiHinh.UseVisualStyleBackColor = true;
            btnDoiHinh.Click += btnDoiHinh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(1086, 58);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(439, 253);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 15;
            picHinhAnh.TabStop = false;
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Location = new Point(378, 161);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(556, 44);
            cboLoaiPhong.TabIndex = 14;
            // 
            // frmPhong
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2126, 1331);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPhong";
            Text = "Phòng";
            Load += frmPhong_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label4;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenPhong;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBox cboLoaiPhong;
        private DataGridView dataGridView1;
        private PictureBox picHinhAnh;
        private Button btnDoiHinh;
        private Button btnThemAnh;
        private DataGridViewTextBoxColumn IDPhong;
        private DataGridViewTextBoxColumn TenPhong;
        private DataGridViewTextBoxColumn TenLoaiPhong;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn SucChua;
        private DataGridViewTextBoxColumn GiaGio;
        private DataGridViewImageColumn HinhAnh;
        private ComboBox cboTrangThai;
        private Button btnKichHoat;
    }
}