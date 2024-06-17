using GGHospital.Dto.Doktor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Dal.Interfaces
{
    public interface IDoktorGetAllDal
    {
        public List<DoktorDto> GetAll(int ID);
    }
}
