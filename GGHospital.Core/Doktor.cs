using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Entities
{
    public class Doktor
    {
        [Key]
        public int DoktorID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Ad { get; set; }

        [MaxLength(50)]
        [Required]
        public string Soyad { get; set; }

        [MaxLength(11)]
        [MinLength(11)]
        [Required]
        public string Tc { get; set; }

        [MaxLength(100)]
        [Required]
        public string Mail { get; set; }

        [MaxLength(8)]
        [MinLength(6)]
        [Required]
        public string Sifre { get; set; }

        [MaxLength(13)]
        [MinLength(13)]
        [Required]
        public string Telefon { get; set; }

        [Required]
        public int BolumID { get; set; }

        [Required]
        public int RolID { get; set; }

        [ForeignKey("BolumID")]
        public virtual Bolum Bolum { get; set; }

        [ForeignKey("RolID")]
        public virtual Rol Rol { get; set; }
    }
}