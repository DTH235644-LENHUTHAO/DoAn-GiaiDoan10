using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.Data
{
    public class LoaiPhong
    {
        public int ID { get; set; }
        public string TenLoaiPhong { get; set; }
        public int SucChua { get; set; }
        public decimal GiaGio { get; set; }
        public virtual ObservableCollectionListSource<Phong> Phong { get; } = new();
    }
}
