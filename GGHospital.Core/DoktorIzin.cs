using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Entities
{
    public class DoktorIzin
    {
        [Key]
        public int DoktorIzinID { get; set; }

        [Required]
        public int DoktorID { get; set; }

        [Required]
        public int IzinID { get; set; }

        [ForeignKey("DoktorID")]
        public virtual Doktor Doktor { get; set; }

        [ForeignKey("IzinID")]
        public virtual Izin Izin { get; set; }
    }
}