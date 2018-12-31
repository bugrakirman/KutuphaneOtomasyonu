using Kutuphane.Lib.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    [Table("Kayitlar")]
    public class Kayit
    {
        [Key]
        [Column(Order =1)]
        public int KitapId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UyeId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Kitap adi 30 karakterden fazla olamaz")]
        public string KitapAdi { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Uye adi 30 karakterden fazla olamaz")]
        public string UyeAdi { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Uye adi 30 karakterden fazla olamaz")]
        public string UyeSoyadi { get; set; }

        [Required]
        public DateTime KiralanmaZamani { get; set; }
        public bool KitapKiradaMi { get; set; }

        public decimal? Ceza { get; set; }

        [ForeignKey("KitapId")]
        public virtual Kitap kitap { get; set; }

        [ForeignKey("UyeId")]
        public virtual Uye uye { get; set; }

    }
}
