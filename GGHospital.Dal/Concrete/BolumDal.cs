using GGHospital.Dal.Interfaces;
using GGHospital.Dto.Bolum;
using GGHospital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Dal.Concrete
{
    public class BolumDal : IBolumDal
    {
        readonly GGHospitalContext _gGHospitalContext;
        public BolumDal(GGHospitalContext gGHospitalContext)
        {
            _gGHospitalContext = gGHospitalContext;

        }
        public List<BolumGetAllDto> GetAll()
        {
            var deger = _gGHospitalContext.Bolum.Select(b => new BolumGetAllDto()
            {
               BolumID = b.BolumID,
               BolumAdi= b.BolumAdi
            }).ToList();
            return deger;
        }
    }
}
