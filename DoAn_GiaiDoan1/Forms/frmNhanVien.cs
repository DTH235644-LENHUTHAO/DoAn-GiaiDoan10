using QuanLyQuanKaraoke.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Reflection.Metadata.Ecma335;

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        QLQKDbContext context = new QLQKDbContext();
        bool xulyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenNV.Enabled = giaTri;
            cboChucVu.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", bindingSource, "TenNV", false, DataSourceUpdateMode.Never);
            cboChucVu.DataBindings.Clear();
            cboChucVu.DataBindings.Add("Text", bindingSource, "ChucVu", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);
            chkTrangThai.DataBindings.Clear();
            chkTrangThai.DataBindings.Add("Checked", bindingSource, "TrangThai", false, DataSourceUpdateMode.Never);

            chkTrangThai.Text = chkTrangThai.Checked ? "Đang làm" : "Đã nghỉ";
            //không cho nhập vào chức vụ mà chỉ chọn từ danh sách có sẵn
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenNV.Clear();
            cboChucVu.SelectedIndex = -1;
            txtDienThoai.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            chkTrangThai.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            NhanVien nv = context.NhanVien.Find(id);

            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!");
                return;
            }

            // nhân viên đã nghỉ
            if (nv.TrangThai == false)
            {
                MessageBox.Show("Nhân viên này đã nghỉ.\n\nBạn không thể chỉnh sửa thông tin.\nBạn có thể khôi phục tài khoản nếu cần.","Không thể chỉnh sửa",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            xulyThem = false;
            BatTatChucNang(true);
            if (dataGridView1.CurrentRow == null) return;
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtMatKhau.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(cboChucVu.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text) || string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtDienThoai.Text.All(char.IsDigit) || txtDienThoai.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }
            if (txtTenNV.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Tên nhân viên không được chứa số!");
                return;
            }
            // Kiểm tra trùng tên đăng nhập
            bool tonTai;

            if (xulyThem)
            {
                tonTai = context.NhanVien.Any(x => x.TenDangNhap == txtTenDangNhap.Text);
            }
            else
            {
                tonTai = context.NhanVien.Any(x => x.TenDangNhap == txtTenDangNhap.Text && x.ID != id);
            }

            if (tonTai)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }
            if (cboChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
                return;
            }



            if (xulyThem)
            {
                NhanVien nv = new NhanVien();
                nv.TenNV = txtTenNV.Text;
                nv.ChucVu = cboChucVu.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.TrangThai = chkTrangThai.Checked;
                //nv.MatKhau = txtMatKhau.Text;
                if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Phải nhập mật khẩu!", "Lỗi");
                    return;
                }
                nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                context.NhanVien.Add(nv);
                context.SaveChanges();
            }
            else
            {
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    nv.TenNV = txtTenNV.Text;
                    nv.ChucVu = cboChucVu.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.TrangThai = chkTrangThai.Checked;
                    //nv.MatKhau = txtMatKhau.Text;
                    //nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                    if (!string.IsNullOrWhiteSpace(txtMatKhau.Text))
                    {
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                    }
                    context.NhanVien.Update(nv);
                    context.SaveChanges();
                }
            }
            frmNhanVien_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if (MessageBox.Show("Xác nhận xóa nhân viên?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    nv.TrangThai = false; // Đánh dấu là đã nghỉ
                    context.NhanVien.Update(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                NhanVien nv = new NhanVien();
                                nv.TenNV = r["TenNV"].ToString();
                                nv.ChucVu = r["ChucVu"].ToString();
                                nv.DienThoai = r["DienThoai"].ToString();
                                nv.TenDangNhap = r["TenDangNhap"].ToString();
                                nv.MatKhau = r["MatKhau"].ToString();
                                string tt = r["TrangThai"].ToString().Trim().ToLower();
                                nv.TrangThai = tt == "đang làm" || tt == "true" || tt == "1";
                                context.NhanVien.Add(nv);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[7] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("TenNV", typeof(string)),
                    new DataColumn("ChucVu", typeof(string)),
                    new DataColumn("DienThoai", typeof(string)),
                    new DataColumn("TenDangNhap", typeof(string)),
                    new DataColumn("MatKhau", typeof(string)),
                    new DataColumn("TrangThai", typeof(bool))
                    });
                    var nhanVien = context.NhanVien.ToList();
                    if (nhanVien != null)
                    {
                        foreach (var p in nhanVien)
                            table.Rows.Add(p.ID, p.TenNV, p.ChucVu, p.DienThoai, p.TenDangNhap, p.MatKhau, p.TrangThai);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void chkTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            chkTrangThai.Text = chkTrangThai.Checked ? "Đang làm" : "Đã nghỉ";
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            NhanVien nv = context.NhanVien.Find(id);

            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!");
                return;
            }

            if (nv.TrangThai == true)
            {
                MessageBox.Show("Nhân viên này đang hoạt động rồi!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Khôi phục tài khoản nhân viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                nv.TrangThai = true; 
                context.NhanVien.Update(nv);
                context.SaveChanges();

                MessageBox.Show("Khôi phục thành công!");

                frmNhanVien_Load(sender, e); 
            }
        }
    }
}
