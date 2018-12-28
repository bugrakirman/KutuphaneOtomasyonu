using Kutuphane.Lib.Models;
using KutuphaneOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kutuphane.Lib.Entities
{
    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Kitap adi 30 karakterden fazla olamaz")]
        [Index("IX_KitapUnique", IsUnique = true)]
        public string KitapAdi { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Yazar adi 30 karakterden fazla olamaz")]
        public string YazarAdi { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Kitap adi 30 karakterden fazla olamaz")]
        public string YazarSoyadi { get; set; }

        public KitapKategorileri Kategori { get; set; }

        public int YazarId { get; set; }
        [ForeignKey("YazarId")]
        public virtual Yazar yazar { get; set; }

   
     
        
    }
}
