using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Forma;



namespace Forma.Data
{
    public class Context : DbContext
    {
        public Context() : base()
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=TestKorisnici; Trusted_Connection=true");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Model.ProizvodiNadrudzbe>()
                .HasKey(a => new { a.NarudzbaId, a.ProizvodId });
        }

        public DbSet<Model.KorisnikModel> Korisnici { get; set; }
        public DbSet<Model.PrijavaModel> Prijave { get; set; }
        
        public DbSet<Model.ProizvodModel> Proizvodi { get; set; }

        public DbSet<Model.Narudzbe> Narudzbe { get; set; }

        public DbSet<Model.ProizvodiNadrudzbe> ProizvodiNadrudzbe { get; set; }
    }
}
