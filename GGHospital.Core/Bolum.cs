using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GGHospital.Entities
{
    [Table("Bolum")]
    public class Bolum
    {
        [Key]
        public int BolumID { get; set; }

        [Required]
        [MaxLength(50)]
        public string BolumAdi { get; set; }

        public List<Doktor> Doktorlar { get; set; }
    }
}