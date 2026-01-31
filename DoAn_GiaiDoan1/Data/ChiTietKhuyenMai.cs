using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class ChiTietKhuyenMai
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public string KhuyenMaiID { get; set; } 
        public decimal SoTienGiam { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual KhuyenMai KhuyenMai { get; set; } = null!;

    }
}
