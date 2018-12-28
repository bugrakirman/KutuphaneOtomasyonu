using Kutuphane.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Lib.Entities
{
    [Table("Yazarlar")]
    public class Yazar
    {
        [Key]
        public int YazarId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Yazar adi 30 karakterden fazla olamaz")]
        public string YazarAdi { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Kitap adi 30 karakterden fazla olamaz")]
        public string YazarSoyadi { get; set; }

        public KitapKategorileri Kategori { get; set; }

        public virtual ICollection<Kitap> kitaplar { get; set; } = new HashSet<Kitap>();
    }
}
