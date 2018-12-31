using KutuphaneOtomasyonu.Entities;

namespace Kutuphane.Lib.ViewModals
{
    public class KitapViewModel
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public KitapKategorileri Kategori { get; set; }
        public override string ToString() => $"{KitapAdi} -- {YazarAdi} {YazarSoyadi} -- {Kategori}";
    }
}
