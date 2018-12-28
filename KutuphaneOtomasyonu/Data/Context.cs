using Kutuphane.Lib.Entities;
using Kutuphane.Lib.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Kutuphane.Lib.Data
{
    public class Context : DbContext
    {
        public Context() : base("name=MyDB")
        {


        }

        public virtual DbSet<Kitap> Kitaplar { get; set; }
        //public virtual DbSet<Kayit> Kayitlar { get; set; }
        public virtual DbSet<Yazar> Yazarlar { get; set; }
        //public virtual DbSet<Uye> Uyeler { get; set; }

        //public List<Kayit> Kayitlar = new List<Kayit>();
        //public List<Kitap> Kitaplar = new List<Kitap>();
        //public List<Yazar> Yazarlar = new List<Yazar>();
        //public List<Uye> Uyeler = new List<Uye>();
    }
}
