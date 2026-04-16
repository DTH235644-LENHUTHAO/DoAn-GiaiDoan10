using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyQuanKaraoke.Data
{
    public class SuDungDichVu
    {
        public int ID { get; set; }
        public int DatPhongID { get; set; }
        public int DichVuID { get; set; }
        public int SoLuong { get; set; }
        public virtual DatPhong DatPhong { get; set; } = null!;
        public virtual DichVu DichVu { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachSuDungDichVu
    {
        public int ID { get; set; }
        public int DatPhongID { get; set; }
        public int DichVuID { get; set; }
        public string TenDV { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }


    }

    [NotMapped]
    public class DanhSachSuDungDichVu2
    {
        public int ID { get; set; }
        public int DatPhongID { get; set; }
        public int DichVuID { get; set; }
        public string TenDV { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

    }


    [NotMapped]
    public class DanhSachSuDungDichVuThongKe
    {
        public int ID { get; set; }
        public int DatPhongID { get; set; }
        public int DichVuID { get; set; }
        public string TenPhong { get; set; }
        public string TenDV { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

    }




}
