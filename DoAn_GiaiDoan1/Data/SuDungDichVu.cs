using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_GiaiDoan1.Data
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
}
