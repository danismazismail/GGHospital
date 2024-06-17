using GGHospital.Dal.Interfaces;
using GGHospital.Dto.Doktor;
using GGHospital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Dal.Concrete
{
    public class DoktorDal : IDoktorGetAllDal
    {
        readonly GGHospitalContext _context;
        public DoktorDal(GGHospitalContext context)
        {
            _context = context;
        }
        public List<DoktorDto> GetAll(int ID)
        {
            var bolumlereGoreDoktorlar=_context.Doktor.Where(a=>a.BolumID==ID).Select(a=>new DoktorDto()
            {
                DoktorID=a.BolumID,
                Ad=a.Ad,
                Soyad=a.Soyad

            }).ToList();
            return bolumlereGoreDoktorlar;
        }
    }
}
