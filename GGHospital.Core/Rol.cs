using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Entities
{
    [Table("Rol")]
    public class Rol
    {
        [Key]
        public int RolID { get; set; }
        [MaxLength(50)]
        [Required]
        public string RolAdi { get; set;}

        public List<Doktor> Doktorlar { get; set; }
        public List<Hasta> Hastalar { get; set; }

    }
}
