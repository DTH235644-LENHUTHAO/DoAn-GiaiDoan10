using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class NhanVien
    {
        public int ID {  get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public string DienThoai { get; set; }
        
        public virtual ObservableCollectionListSource<DatPhong> DatPhong { get; } = new();


    }
}
