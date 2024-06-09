using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Entities
{
    public class Randevu
    {
        [Key]
        public int RandevuID { get; set; }
        [Required]
        public DateTime RandevuTarihi { get; set; }

        [Required]
        public int DoktorID { get; set; }
        [Required]
        public int HastaID { get; set; }
        [ForeignKey("DoktorID")]
        public virtual Doktor Doktor { get; set; }
        [ForeignKey("HastaID")]
        public virtual Hasta Hasta { get; set; }
    }
}