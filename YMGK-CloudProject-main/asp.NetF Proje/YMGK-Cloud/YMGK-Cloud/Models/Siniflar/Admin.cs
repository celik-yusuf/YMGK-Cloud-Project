using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YMGK_Cloud.Models.Siniflar
{
    public class Admin
    {

        [Key]
        public int AdminId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string AdminAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string AdminSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string AdminPassword { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string AdminUlke { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string AdminSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string AdminAdres { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string AdminTelefon { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string AdminMail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string AdminGorsel { get; set; }

        public DateTime AdminKayitTarih { get; set; }

        public bool AdminDurum { get; set; }
    }
}