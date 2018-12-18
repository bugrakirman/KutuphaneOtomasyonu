using Kutuphane.Lib.Models;
using System.Collections.Generic;

namespace Kutuphane.Lib.Data
{
    public class Context
    {
        public List<Kayit> Kayitlar = new List<Kayit>();
        public List<Kitap> Kitaplar = new List<Kitap>();
        public List<Yazar> Yazarlar = new List<Yazar>();
        public List<Uye> Uyeler = new List<Uye>();
    }
}
