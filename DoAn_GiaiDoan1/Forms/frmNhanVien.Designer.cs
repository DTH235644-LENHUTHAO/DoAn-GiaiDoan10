namespace QuanLyQuanKaraoke.Forms
{
    partial class frmNhanVien
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
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDienThoai = new TextBox();
            txtChucVu = new TextBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            DienThaoi = new DataGridViewTextBoxColumn();
            txtTenNV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1406, 261);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(237, 55);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1086, 262);
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
            btnLuu.Location = new Point(1406, 161);
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
            btnXoa.Location = new Point(1086, 160);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(237, 55);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1406, 58);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(237, 55);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1086, 59);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(237, 55);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(378, 267);
            txtDienThoai.Margin = new Padding(4);
            txtDienThoai.Multiline = true;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(556, 50);
            txtDienThoai.TabIndex = 5;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(378, 166);
            txtChucVu.Margin = new Padding(4);
            txtChucVu.Multiline = true;
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(556, 50);
            txtChucVu.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TenNV, ChucVu, DienThaoi });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1716, 679);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Tên nhân viên";
            TenNV.MinimumWidth = 10;
            TenNV.Name = "TenNV";
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 10;
            ChucVu.Name = "ChucVu";
            // 
            // DienThaoi
            // 
            DienThaoi.DataPropertyName = "DienThoai";
            DienThaoi.HeaderText = "Số điện thoại";
            DienThaoi.MinimumWidth = 10;
            DienThaoi.Name = "DienThaoi";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(378, 64);
            txtTenNV.Margin = new Padding(4);
            txtTenNV.Multiline = true;
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(556, 50);
            txtTenNV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 281);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 36);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 180);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 36);
            label2.TabIndex = 1;
            label2.Text = "Chức vụ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 36);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(30, 399);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1722, 722);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtChucVu);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 26);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1722, 367);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên ";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1786, 1147);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNhanVien";
            Text = "Nhân VIên";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDienThoai;
        private TextBox txtChucVu;
        private DataGridView dataGridView1;
        private TextBox txtTenNV;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn DienThaoi;
    }
}