using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGHospital.Entities
{
    public class GGHospitalContextFactory : IDesignTimeDbContextFactory<GGHospitalContext>
    {
        public GGHospitalContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GGHospitalContext>();
            optionsBuilder.UseSqlServer("server=DESKTOP-NVBA98H\\SQLEXPRESS;Database=GGHospitalDB;Trusted_connection=true;TrustServerCertificate=true;");

            return new GGHospitalContext(optionsBuilder.Options);
        }
    }
}
