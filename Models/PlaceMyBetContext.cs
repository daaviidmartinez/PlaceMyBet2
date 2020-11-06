using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication3.Models;

namespace WebApplication1.Models
{
    public class PlaceMyBetContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Mercado> Mercado { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Apuesta> Apuesta { get; set; }

        public PlaceMyBetContext()
        {
        }

        public PlaceMyBetContext(DbContextOptions options)
        : base(options)
        {
        }

        //Metodo de configuracion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=127.0.0.1;Port=3306;Database=placemybet;Uid=root;password=;SslMode=none");

            }
        }

        //Insercion de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario(1,"algo@gad.com", "Pepe", "Pepe", 45));
            modelBuilder.Entity<Cuenta>().HasData(new Cuenta("1", 3434, "Bankia", 12));

        }
    }
}