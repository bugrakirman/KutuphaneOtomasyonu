using Kutuphane.Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    public interface IKitapEkleCikar<T1, T2> where T1 : Yazar where T2 : Kitap
    {
        void KitapEkle(T1 yazara, T2 kitabi);
        void KitapCikart(T1 yazardan, T2 kitabi);
    }
}
