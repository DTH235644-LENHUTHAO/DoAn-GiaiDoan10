using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.Data
{
    public class KhachHang
    {
        public int ID {  get; set; }
        public string TenKH { get; set; }
        public string DienThoai { get; set; }
        public virtual ObservableCollectionListSource<DatPhong> DatPhong { get; } = new();

    }
}
