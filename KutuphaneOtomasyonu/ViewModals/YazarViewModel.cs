

using KutuphaneOtomasyonu.Entities;

namespace Kutuphane.Lib.ViewModals
{
    public class YazarViewModel
    {
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public KitapKategorileri Kategori { get; set; }
        public override string ToString() => $"{YazarAdi} {YazarSoyadi} -- {Kategori}";
    }
}
