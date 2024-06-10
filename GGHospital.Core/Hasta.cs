using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Entities
{
    public class Hasta
    {
        [Key]
        public int HastaID { get; set; }
        [Required]
        [MaxLength(50)]
        public string HastaAdi { get; set; }
        [Required]
        [MaxLength(50)]
        public string HastaSoyadi { get; set; }
        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        public string Tc { get; set; }
        [Required]
        [MaxLength(50)]
        public string Mail { get; set; }
        [Required]
        [MaxLength(8)]
        [MinLength(6)]
        public string Sifre { get; set; }
        [MaxLength(13)]
        [MinLength(13)]
        public string Telefon { get; set; }
        [Required]
        public int RolID { get; set; }
        [ForeignKey("RolID")]
        public Rol Rol { get; set; }
        public List<Randevu> Randevular { get; set; }
    }
}
