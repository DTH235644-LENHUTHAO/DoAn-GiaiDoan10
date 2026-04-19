using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyQuanKaraoke.Data
{
    public class HoaDon
    {
        public int ID {  get; set; }
        public int DatPhongID { get; set; }
        public int? KhuyenMaiID { get; set; }
        public DateTime ThoiGianLap {  get; set; }
        public decimal TongTien {  get; set; }


        public virtual ObservableCollectionListSource<ChiTietHoaDon> ChiTietHoaDon { get; } = new();
        public virtual KhuyenMai KhuyenMai { get; set; } = null!;
        public virtual ObservableCollectionListSource<ThanhToan> ThanhToan { get; } = new();


        public virtual DatPhong DatPhong { get; set; } = null!;

    }
    [NotMapped]
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public int DatPhongID { get; set; }
        public int PhongID { get; set; }
        public string TenPhong { get; set; }
        public int NhanVienID { get; set; }
        public string TenNV { get; set; }
        public int KhachHangID { get; set; }
        public string TenKH { get; set; }
        public int? KhuyenMaiID { get; set; }
        public string TenKhuyenMai { get; set; }
        public DateTime ThoiGianLap { get; set; }
        public decimal TongTien { get; set; }
        public string? XemChiTiet { get; set; }
    }
}
