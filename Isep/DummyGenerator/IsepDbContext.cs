using Isep.Model.Dwh;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;


namespace Isep
{
    public class IsepDbContext: DbContext
    {

        public IsepDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite("Data Source=Database.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Projekt>()
                        .HasOne(a => a.Projekt_prac_vazba)
                        .WithOne(a => a.Projekt)
                        .HasForeignKey<Projekt_prac_vazba>(c => c.Projekt_Id);

            modelBuilder.Entity<Navrh>()
            .HasOne(a => a.Navrh_Prac_vazba)
            .WithOne(a => a.Navrh)
            .HasForeignKey<NAVRH_prac_vazba>(c => c.Navrh_Id);

            modelBuilder.Entity<Vav_role_osoba>().HasData(
                new Vav_role_osoba { ROLE_OSOBA_ID = 'H', Popis = "Řešitel" },
                new Vav_role_osoba { ROLE_OSOBA_ID = 'A', Popis = "Administrátor" },
                new Vav_role_osoba { ROLE_OSOBA_ID = 'K', Popis = "Kontaktní osoba" },
                new Vav_role_osoba { ROLE_OSOBA_ID = 'S', Popis = "Člen realizačního týmu" });
        }

        public DbSet<Projekt> Projekt { get; set; }
        public DbSet<Projekt_prac_vazba> Prac_vazba { get; set; }

        public DbSet<Projekt_rozpocet> Rozpocet { get; set; }
        public DbSet<Projekt_Osoba> Projekt_osoby { get; set; }
        public DbSet<Vav_role_osoba> Vav_role { get; set; }
        public DbSet<Navrh> Navrh { get; set; }
        public DbSet<NAVRH_prac_vazba> NAVRH_prac_vazba { get; set; }
        public DbSet<NAVRH_osoba> NAVRH_osoby { get; set; }
        // public DbSet<NAVRH_STAV_ciselnik> Stavy { get; set; }

    }
}
