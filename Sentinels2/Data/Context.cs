using Microsoft.EntityFrameworkCore;
using Sentinels2.Models;
using System.Reflection;

namespace Sentinels2.Data
{
    internal class Context : DbContext
    {
        public DbSet<Afastamento> Afastamentos { get; set; }
        public DbSet<DemandaExtra> DemandaExtras { get; set; }
        public DbSet<Desligamento> Desligamentos { get; set; }
        public DbSet<Escala> Escalas { get; set; }
        public DbSet<Feriado> Feriados { get; set; }
        public DbSet<LicencaPremio> LicencasPremio { get; set; }
        public DbSet<OpcaoDeFerias> OpcoesDeFerias { get; set; }
        public DbSet<Patrimonio> Patrimonios { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vigia> Vigias { get; set; }

        public string DbPath { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {

            options.UseSqlite(connectionString: $"Filename=vgmcatanduva2.db",
                sqliteOptionsAction: op => {
                    op.MigrationsAssembly(
                        Assembly.GetExecutingAssembly().FullName    
                    );
                });

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Afastamento>().ToTable("Afastamento");
            modelBuilder.Entity<Afastamento>().HasKey(e => e.Id);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DemandaExtra>().ToTable("DemandaExtra");
            modelBuilder.Entity<DemandaExtra>().HasKey(e => e.Id);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Desligamento>().ToTable("Desligamento");
            modelBuilder.Entity<Desligamento>().HasKey(e => e.Matricula);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Escala>().ToTable("Escala");
            modelBuilder.Entity<Escala>().HasKey(e => e.OS);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Feriado>().ToTable("Feriado");
            modelBuilder.Entity<Feriado>().HasKey(e => e.Data);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LicencaPremio>().ToTable("LicencaPremio");
            modelBuilder.Entity<LicencaPremio>().HasKey(e => e.Certidao);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OpcaoDeFerias>().ToTable("OpcaoDeFerias");
            modelBuilder.Entity<OpcaoDeFerias>().HasKey(e => e.AnoReferencia);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patrimonio>().ToTable("Patrimonio");
            modelBuilder.Entity<Patrimonio>().HasKey(e => e.Id);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>().HasKey(e => e.Email);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vigia>().ToTable("Vigia");
            modelBuilder.Entity<Vigia>().HasKey(e => e.Matricula);
            base.OnModelCreating(modelBuilder);
        }
    }
}
