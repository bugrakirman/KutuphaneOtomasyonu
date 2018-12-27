using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Models
{
    public class Kitap
    {
        public string KitapAd { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public KitapKategorileri Kategori { get; set; }
        public override string ToString()
        {
            return $"{this.KitapAd} - {this.YazarAd} {this.YazarSoyad} - {this.Kategori}";
        }
    }
}
