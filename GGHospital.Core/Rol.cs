﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Entities
{
    public class Rol
    {
        [Key]
        public int RolID { get; set; }
        [MaxLength(50)]
        [Required]
        public string RolAdi { get; set;}

    }
}
