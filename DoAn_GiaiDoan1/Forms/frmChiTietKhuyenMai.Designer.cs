namespace QuanLyQuanKaraoke.Forms
{
    partial class frmChiTietKhuyenMai
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenKhuyenMai = new DataGridViewTextBoxColumn();
            PhanTramGiam = new DataGridViewTextBoxColumn();
            ThoiDiemApDung = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label3 = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            txtGhiChu = new TextBox();
            label4 = new Label();
            label2 = new Label();
            cboKhuyenMai = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(27, 394);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1722, 722);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khuyến mãi";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TenKhuyenMai, PhanTramGiam, ThoiDiemApDung, GhiChu });
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
            // TenKhuyenMai
            // 
            TenKhuyenMai.DataPropertyName = "TenKhuyenMai";
            TenKhuyenMai.HeaderText = "Tên khuyến mãi";
            TenKhuyenMai.MinimumWidth = 10;
            TenKhuyenMai.Name = "TenKhuyenMai";
            // 
            // PhanTramGiam
            // 
            PhanTramGiam.DataPropertyName = "PhanTramGiam";
            PhanTramGiam.HeaderText = "Phần trăm giảm";
            PhanTramGiam.MinimumWidth = 10;
            PhanTramGiam.Name = "PhanTramGiam";
            // 
            // ThoiDiemApDung
            // 
            ThoiDiemApDung.DataPropertyName = "ThoiDiemApDung";
            ThoiDiemApDung.HeaderText = "Thời điểm áp dụng";
            ThoiDiemApDung.MinimumWidth = 10;
            ThoiDiemApDung.Name = "ThoiDiemApDung";
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 10;
            GhiChu.Name = "GhiChu";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 281);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 36);
            label3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 36);
            label1.TabIndex = 0;
            label1.Text = "Khuyến mãi :";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboKhuyenMai);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 21);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1722, 367);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khuyến mãi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(385, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(551, 44);
            dateTimePicker1.TabIndex = 16;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(205, 249);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(834, 44);
            txtGhiChu.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 257);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 36);
            label4.TabIndex = 14;
            label4.Text = "Ghi chú :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(307, 36);
            label2.TabIndex = 13;
            label2.Text = "Thời điểm áp dụng: :";
            // 
            // cboKhuyenMai
            // 
            cboKhuyenMai.FormattingEnabled = true;
            cboKhuyenMai.Location = new Point(299, 65);
            cboKhuyenMai.Name = "cboKhuyenMai";
            cboKhuyenMai.Size = new Size(467, 44);
            cboKhuyenMai.TabIndex = 12;
            // 
            // frmChiTietKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1779, 1140);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmChiTietKhuyenMai";
            Text = "Chi tiết khuyến mãi";
            Load += frmChiTietKhuyenMai_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label3;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox1;
        private ComboBox cboKhuyenMai;
        private TextBox txtGhiChu;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenKhuyenMai;
        private DataGridViewTextBoxColumn PhanTramGiam;
        private DataGridViewTextBoxColumn ThoiDiemApDung;
        private DataGridViewTextBoxColumn GhiChu;
    }
}