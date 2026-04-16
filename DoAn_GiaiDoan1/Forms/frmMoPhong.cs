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

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmMoPhong : Form
    {
        QLQKDbContext context = new QLQKDbContext();
        int phongID;
        int nhanVienID;
        public frmMoPhong(int phongID, int nhanVienID)
        {
            InitializeComponent();
            this.phongID = phongID;
            this.nhanVienID = nhanVienID;
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            lblPhong.Text = context.Phong.Find(phongID).TenPhong;
            lblNhanVien.Text = "Nhân viên mở phòng : "+context.NhanVien.Find(nhanVienID).TenNV;

        }

        private void btnMoPhong_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(dienThoai))
            {
                MessageBox.Show("Nhập tên và số điện thoại!");
                return;
            }

            // tìm khách hàng theo SĐT và tên không phân biệt hoa thường
            var kh = context.KhachHang
                .FirstOrDefault(x => x.DienThoai == dienThoai && x.TenKH.ToLower() == tenKH.ToLower());

            if (kh == null)
            {
                // thêm mới khách hàng nếu chưa có
                kh = new KhachHang
                {
                    TenKH = tenKH,
                    DienThoai = dienThoai
                };

                context.KhachHang.Add(kh);
                context.SaveChanges();
            }

            // tạo đặt phòng
            DatPhong dp = new DatPhong
            {
                PhongID = phongID,
                NhanVienID = nhanVienID,
                KhachHangID = kh.ID,
                ThoiGianBatDau = DateTime.Now
            };

            context.DatPhong.Add(dp);
            context.SaveChanges();

            MessageBox.Show("Mở phòng thành công!");
            this.Close();
        }
    }
}
