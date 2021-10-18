using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroDetalleAct.Entidades;



namespace RegistroDetalleAct.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite(@"Data Source = DATA\RegistroDatalleAct.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 1,
                Nombre = "Permiso",
                Descripcion = "Permiso otorgado"
            });

            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 2,
                Nombre = "Permiso de Emergencia",
                Descripcion = "Permiso otorgado por inconveniente"
            });

            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 3,
                Nombre = "Permiso de Salud",
                Descripcion = "Permiso otorgado para licencia de salud"
            });

            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 4,
                Nombre = "Permiso por Fallecimiento",
                Descripcion = "Permiso otorgado por muerte de un familiar"
            });
        }
    }
}
