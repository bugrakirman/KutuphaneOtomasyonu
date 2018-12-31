using KutuphaneOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Business
{
    public class KiralamaBusiness
    {
        public void CezaHesapla(double gecenGun)
        {
            Kayit kyt = new Kayit();
            kyt.Ceza = (Convert.ToDecimal(gecenGun)-7) * 5;
        }
    }
}
