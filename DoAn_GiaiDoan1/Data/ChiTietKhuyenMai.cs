using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuanLyQuanKaraoke.Data
{
    public class ChiTietKhuyenMai
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int KhuyenMaiID { get; set; }
        public DateTime ThoiDiemApDung { get; set; }
        public string? GhiChu { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual KhuyenMai KhuyenMai { get; set; } = null!;

    }
    [NotMapped]
    public class DanhSachChiTietKhuyenMai
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int KhuyenMaiID { get; set; }
        public string TenKhuyenMai { get; set; }
        public decimal PhanTramGiam { get; set; }
        public DateTime ThoiDiemApDung { get; set; }
        public string? GhiChu { get; set; }

    }
}
