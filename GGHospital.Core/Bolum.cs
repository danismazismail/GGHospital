using System.ComponentModel.DataAnnotations;

namespace GGHospital.Entities
{
    public class Bolum
    {
        [Key]
        public int BolumID { get; set; }

        [Required]
        [MaxLength(50)]
        public string BolumAdi { get; set; }
    }
}