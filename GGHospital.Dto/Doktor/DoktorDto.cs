using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Dto.Doktor
{
    public class DoktorDto
    {
        public int DoktorID { get; set; }

        
        public string Ad { get; set; }

        
        public string Soyad { get; set; }

        
        public string Tc { get; set; }

       
        public string Mail { get; set; }

        
        public string Sifre { get; set; }

       
        public string Telefon { get; set; }

        
        public int BolumID { get; set; }
        public int IzinID { get; set; }

        public DateTime? IzinBaslangicTarihi { get; set; } = DateTime.Now.AddDays(1);

       
        public DateTime IzinBitisTarihi { get; set; }

      
        public int RolID { get; set; }
    }
}
