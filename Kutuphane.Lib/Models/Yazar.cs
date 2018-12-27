using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Models
{
    public class Yazar
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public KitapKategorileri Kategori { get; set; }

        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();

        public override string ToString()
        {
            return $"{this.Ad}  {this.Soyad} - {this.Kategori}";
        }
        
    }
}
