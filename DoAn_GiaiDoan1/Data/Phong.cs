using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class Phong
    {
        public int ID { get; set; }
        public string TenPhong{ get; set;}
        public string LoaiPhongID { get; set;}
        public string TrangThai { get; set;}

        public virtual LoaiPhong LoaiPhong { get; set; } = null!;

        public virtual ObservableCollectionListSource<DatPhong> DatPhong { get; } = new();
    }
}
