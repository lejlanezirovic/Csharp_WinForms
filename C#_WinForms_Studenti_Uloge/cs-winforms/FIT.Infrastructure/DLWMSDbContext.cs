﻿using FIT.Data;

using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmeti> Predmeti { get; set; }
        public DbSet<PolozeniPredmeti> PolozeniPredmeti { get; set; }
        public DbSet<Uloge> Uloge { get; set; }
        public DbSet<StudentiUloge> StudentiUloge { get; set; }
        public DbSet<Semestri> Semestri { get; set; }

        public DbSet<StudentiPoruke> StudentiPoruke { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(x => x.Polozeni)
                .WithOne(x => x.Student);

            modelBuilder.Entity<Student>()
                .HasMany(x => x.Uloge)
                .WithOne(x => x.Student);

            modelBuilder.Entity<Student>()
                .HasMany(x => x.Poruke)
                .WithOne(x => x.Student);
        }
    }
}