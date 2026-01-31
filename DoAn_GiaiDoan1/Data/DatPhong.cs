using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class DatPhong
    {
        public int ID {  get; set; }
        public int PhongID { get; set; }
        public int KhachHangID {  get; set; }
        public int NhanVienID { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public virtual Phong Phong { get; set; } = null!;
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();

        public virtual ObservableCollectionListSource<SuDungDichVu> SuDungDichVu { get; } = new();



    }
}
