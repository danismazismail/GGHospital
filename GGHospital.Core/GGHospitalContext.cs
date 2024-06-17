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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Hasta - Rol
            modelBuilder.Entity<Hasta>()
                .HasOne(h => h.Rol)
                .WithMany(r => r.Hastalar)
                .HasForeignKey(h => h.RolID)
                .OnDelete(DeleteBehavior.NoAction);

            // Doktor - Rol
            modelBuilder.Entity<Doktor>()
                .HasOne(d => d.Rol)
                .WithMany(r => r.Doktorlar)
                .HasForeignKey(d => d.RolID)
                .OnDelete(DeleteBehavior.NoAction);

            // Randevu - Hasta
            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.Hasta)
                .WithMany(h => h.Randevular)
                .HasForeignKey(r => r.HastaID)
                .OnDelete(DeleteBehavior.NoAction);

            // Randevu - Doktor
            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.Doktor)
                .WithMany(d => d.Randevular)
                .HasForeignKey(r => r.DoktorID)
                .OnDelete(DeleteBehavior.NoAction);

            // Diğer ilişkiler ve konfigürasyonlar buraya eklenebilir
        }
    }

}
