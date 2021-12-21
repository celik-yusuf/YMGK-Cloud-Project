using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YMGK_Cloud.Models.Siniflar
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UserAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string UserSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string UserPassword { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string UserUlke { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string UserSehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string UserAdres { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string UserTelefon { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string UserMail { get; set; }

        public bool UserMailConfirmed { get; set; }

        public bool twoFAEnabled { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string UserGorsel { get; set; }

        public DateTime UserKayitTarih { get; set; }

        public bool UserDurum { get; set; }
    }
}