using QuanLyQuanKaraoke.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QuanLyQuanKaraoke.Helpers;

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        QLQKDbContext context = new QLQKDbContext();
        bool xulyThem = false;
        int id;
        //string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Images");
        //string imagesFolder = Path.Combine(Application.StartupPath, "Images");
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        string hinhAnhTam = "";

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenPhong.Enabled = giaTri;
            cboLoaiPhong.Enabled = giaTri;
            cboTrangThai.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnDoiHinh.Enabled = giaTri;
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {

            BatTatChucNang(false);

            dataGridView1.AutoGenerateColumns = false;

            cboLoaiPhong.DataSource = context.LoaiPhong.ToList();
            cboLoaiPhong.DisplayMember = "TenLoaiPhong";
            cboLoaiPhong.ValueMember = "ID";

            /*var ds = context.Phong
                .Include(p => p.LoaiPhong)
                .Select(p => new
                {
                    p.ID,
                    p.TenPhong,
                    p.TrangThai,
                    p.LoaiPhongID,
                    p.HinhAnh,
                    LoaiPhong = p.LoaiPhong.TenLoaiPhong,
                    SucChua = p.LoaiPhong.SucChua,
                    GiaGio = p.LoaiPhong.GiaGio
                })
                .ToList();*/

            List<DanhSachPhong> p = new List<DanhSachPhong>();
            p = context.Phong.Select(r => new DanhSachPhong
            {
                ID = r.ID,
                TenPhong = r.TenPhong,
                TrangThai = r.TrangThai,
                LoaiPhongID = r.LoaiPhongID,
                HinhAnh = r.HinhAnh,
                TenLoaiPhong = r.LoaiPhong.TenLoaiPhong,
                SucChua = r.LoaiPhong.SucChua,
                GiaGio = r.LoaiPhong.GiaGio
            }).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = p;

            txtTenPhong.DataBindings.Clear();
            txtTenPhong.DataBindings.Add("Text", bs, "TenPhong", false, DataSourceUpdateMode.Never);

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Text", bs, "TrangThai", false, DataSourceUpdateMode.Never);

            cboLoaiPhong.DataBindings.Clear();
            cboLoaiPhong.DataBindings.Add("SelectedValue", bs, "LoaiPhongID", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bs, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                if (e.Value != null)
                    e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            dataGridView1.DataSource = bs;


        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);

            txtTenPhong.Clear();
            cboTrangThai.SelectedIndex = -1;
            cboLoaiPhong.SelectedIndex = -1;
            picHinhAnh.Image = null;
            hinhAnhTam = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string trangThai = dataGridView1.CurrentRow.Cells["TrangThai"].Value.ToString();

            // ngưng hoạt động thì không cho sửa
            if (trangThai == "Ngưng hoạt động")
            {
                MessageBox.Show("Phòng đã ngưng hoạt động, không thể chỉnh sửa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            xulyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDPhong"].Value);

            var fileName = dataGridView1.CurrentRow.Cells["HinhAnh"].Value?.ToString();
            hinhAnhTam = fileName;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenPhong.Text) || string.IsNullOrWhiteSpace(cboLoaiPhong.Text) || string.IsNullOrWhiteSpace(cboTrangThai.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {


                if (xulyThem)
                {
                    Phong p = new Phong();
                    p.TenPhong = txtTenPhong.Text;
                    p.TrangThai = cboTrangThai.Text;
                    p.LoaiPhongID = (int)cboLoaiPhong.SelectedValue;
                    p.HinhAnh = hinhAnhTam;
                    context.Phong.Add(p);
                    context.SaveChanges();
                }
                else
                {
                    Phong p = context.Phong.Find(id);
                    if (p != null)
                    {
                        p.TenPhong = txtTenPhong.Text;
                        p.TrangThai = cboTrangThai.Text;
                        p.LoaiPhongID = (int)cboLoaiPhong.SelectedValue;
                        //p.HinhAnh = hinhAnhTam;
                        if (!string.IsNullOrEmpty(hinhAnhTam))
                        {
                            p.HinhAnh = hinhAnhTam;
                        }
                        context.Phong.Update(p);
                        context.SaveChanges();
                    }
                }
                frmPhong_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận ngưng phòng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDPhong"].Value.ToString());

                Phong p = context.Phong.Find(id);
                if (p != null)
                {
                    p.TrangThai = "Ngưng hoạt động"; // đổi trạng thái
                    context.Phong.Update(p);
                    context.SaveChanges();
                }

                frmPhong_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmPhong_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu cột là cột hình ảnh
            if (dataGridView1.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                if (e.Value != null)
                {
                    string fileName = e.Value.ToString();
                    string path = Path.Combine(imagesFolder, fileName);

                    if (File.Exists(path))
                    {
                        Image img = Image.FromFile(path);

                        e.Value = new Bitmap(img, 60, 60); // resize

                        img.Dispose(); // giải phóng
                    }
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                string trangThai = e.Value?.ToString();

                if (trangThai == "Bình thường")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else if (trangThai == "Ngưng hoạt động")
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                }
                else if (trangThai == "Bảo trì")
                {
                    e.CellStyle.BackColor = Color.Khaki;
                }
            }
        }

        private void btnDoiHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName.GenerateSlug() + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                
                picHinhAnh.ImageLocation = fileSavePath;


                hinhAnhTam = fileName.GenerateSlug() + ext;
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                string ext = Path.GetExtension(ofd.FileName);
                string newName = fileName.GenerateSlug() + ext;

                string savePath = Path.Combine(imagesFolder, newName);
                File.Copy(ofd.FileName, savePath, true);


                picHinhAnh.ImageLocation = savePath;


                hinhAnhTam = newName;
            }
        }

        private void btnKichHoat_Click(object sender, EventArgs e)
        {
            /*id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDPhong"].Value.ToString());

            Phong p = context.Phong.Find(id);
            if (p != null)
            {
                p.TrangThai = "Bình thường";
                context.Phong.Update(p);
                context.SaveChanges();
            }

            frmPhong_Load(sender, e);*/
        }

        private void btnKichHoat_Click_1(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDPhong"].Value.ToString());

            Phong p = context.Phong.Find(id);
            if (p != null)
            {
                p.TrangThai = "Bình thường";
                context.Phong.Update(p);
                context.SaveChanges();
            }

            frmPhong_Load(sender, e);
        }



    }
}

