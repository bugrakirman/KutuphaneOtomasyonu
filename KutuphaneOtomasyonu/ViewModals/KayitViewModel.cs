using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModals
{
    public class KayitViewModel
    {
        public int KitapId { get; set; }
        public int UyeId { get; set; }
        public string KitapAdi { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public DateTime KiralanmaZamani { get; set; }
        public bool KitapKiradaMi { get; set; }
        public decimal? Ceza { get; set; }
        public override string ToString() => $"{KitapAdi} -- {UyeAdi} {UyeSoyadi}";
    }
}
