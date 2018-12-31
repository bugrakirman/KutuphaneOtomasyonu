using Kutuphane.Lib.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneOtomasyonu.Entities
{
    [Table("Uyeler")]
    public class Uye
    {

        [Key]
        public int UyeId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Uye adi 30 karakterden fazla olamaz")]
        public string UyeAdi { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Uye Soyadi 30 karakterden fazla olamaz")]
        public string UyeSoyadi { get; set; }

        public virtual ICollection<Kayit> kayitlar { get; set; } = new HashSet<Kayit>();
    }
}
