﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GGHospital.Entities
{
    public class Izin
    {
        [Key]
        public int IzinID { get; set; }

        public DateTime? IzinBaslangicTarihi { get; set; } = DateTime.Now.AddDays(1);

        [Required]
        public DateTime IzinBitisTarihi { get; set; }

        [Required]
        public int DoktorID { get; set; }

        [ForeignKey("DoktorID")]
        public Doktor Doktor { get; set; }
    }
}