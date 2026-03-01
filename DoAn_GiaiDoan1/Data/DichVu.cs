using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanKaraoke.Data
{
    public class DichVu
    {
        public int ID { get; set; }
        public string TenDV { get; set; }
        public decimal DonGia {  get; set; }
        public virtual ObservableCollectionListSource<SuDungDichVu> SuDungDichVu { get; } = new();

    }
}
