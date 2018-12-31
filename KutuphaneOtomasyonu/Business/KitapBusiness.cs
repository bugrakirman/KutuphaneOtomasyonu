using Kutuphane.Lib.Entities;
using KutuphaneOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Business
{
    public class KitapBusiness : IKitapEkleCikar<Yazar, Kitap>
    {
        public void KitapCikart(Yazar yazardan, Kitap kitabi)
        {
            yazardan.kitaplar.Remove(kitabi);
        }

        public void KitapEkle(Yazar yazara, Kitap kitabi)
        {
            yazara.kitaplar.Add(kitabi);
        }
    }
}
