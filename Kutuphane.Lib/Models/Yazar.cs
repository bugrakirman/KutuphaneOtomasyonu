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

        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();

    }
}
