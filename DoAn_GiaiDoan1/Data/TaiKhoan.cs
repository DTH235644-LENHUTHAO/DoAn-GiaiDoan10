using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.Data
{
    public class TaiKhoan
    {
        public int ID { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }
        public bool TrangThai { get; set; }

        public int NhanVienID { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
