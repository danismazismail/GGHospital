using GGHospital.Dto.Bolum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Dal.Interfaces
{
    public interface IBolumDal
    {
        public List<BolumGetAllDto> GetAll();
    }
}
