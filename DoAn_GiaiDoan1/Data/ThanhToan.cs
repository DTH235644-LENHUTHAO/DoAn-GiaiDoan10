using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
{
    public class ThanhToan
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public decimal SoTien { get; set; }
        public string PhuongThuc { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
    }
}
