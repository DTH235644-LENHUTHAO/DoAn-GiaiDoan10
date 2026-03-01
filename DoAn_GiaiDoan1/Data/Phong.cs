using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuanLyQuanKaraoke.Data
{
    public class Phong
    {
        public int ID { get; set; }
        public string TenPhong { get; set; }
        public int LoaiPhongID { get; set; }
        public string TrangThai { get; set; }
        public string? HinhAnh { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; } = null!;

        public virtual ObservableCollectionListSource<DatPhong> DatPhong { get; } = new();
    }

    [NotMapped]
    public class DanhSachPhong
    {
        public int ID { get; set; }
        public string TenPhong { get; set; }
        public int LoaiPhongID { get; set; }
        public string TrangThai { get; set; }
        public string? HinhAnh { get; set; }
        public string TenLoaiPhong { get; set; }
        public int SucChua { get; set; }
        public decimal GiaGio { get; set; }
    }
}
