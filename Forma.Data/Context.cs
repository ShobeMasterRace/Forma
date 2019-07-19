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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Korisnici; Trusted_Connection=true");

        }

        public DbSet<Model.KorisnikModel> Korisnici { get; set; }


    }
}
