using Kutuphane.Lib.Models;

namespace Kutuphane.Lib.ViewModals
{
    public class YazarViewModel
    {
        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public KitapKategorileri Kategori { get; set; }
    }
}
