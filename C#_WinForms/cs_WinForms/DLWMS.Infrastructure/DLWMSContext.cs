using DLWMS.Data;

using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace DLWMS.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(konekcijskiString);
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<Spolovi> Spolovi { get; set; }
        public DbSet<Predmet> Predmet { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<AkademskaGodina> AkademskaGodina { get; set; }
        public DbSet<Univerziteti> Univerziteti { get; set; }
        public DbSet<Razmjene> Razmjene { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzava>()
                .HasMany(x => x.gradovi)
                .WithOne(x => x.Drzava);

            modelBuilder.Entity<Student>()
               .HasMany(x => x.RazmjeneStudenta)
               .WithOne(x => x.Student);
        }

    }
}
