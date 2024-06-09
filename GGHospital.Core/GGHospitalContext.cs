using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Linq;

namespace GGHospital.Entities
{
    public class GGHospitalContext : DbContext
    {
        public GGHospitalContext(DbContextOptions<GGHospitalContext> gghospital) : base(gghospital)
        {

        }


        public DbSet<Hasta> Hasta { get; set; }
        public DbSet<Randevu> Randevu { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Bolum> Bolum { get; set; }
        public DbSet<Doktor> Doktor { get; set; }
        
        public DbSet<Izin> Izin { get; set; }
    }
}
