using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregableEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Ordenes> Ordenes { get; set; }

        public DbSet<OrdenDetalle> OrdenDetalle { get; set; }

        protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=.;
            Database=VentasDB;
            Trusted_Connection=True;
            TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(ApplicationDbContext).Assembly);
        }
    }
}
