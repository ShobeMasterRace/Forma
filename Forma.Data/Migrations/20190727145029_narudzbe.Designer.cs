﻿// <auto-generated />
using System;
using Forma.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forma.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190727145029_narudzbe")]
    partial class narudzbe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Forma.Data.Model.KorisnikModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojUkucana");

                    b.Property<string>("Grad");

                    b.Property<string>("Ime")
                        .IsRequired();

                    b.Property<string>("PostanskiBroj");

                    b.Property<string>("Prezime")
                        .IsRequired();

                    b.Property<string>("Ulica");

                    b.Property<string>("Upit")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Forma.Data.Model.Narudzbe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("TimeStamp");

                    b.HasKey("ID");

                    b.ToTable("Narudzbe");
                });

            modelBuilder.Entity("Forma.Data.Model.PrijavaModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Prijave");
                });

            modelBuilder.Entity("Forma.Data.Model.ProizvodModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cijena");

                    b.Property<string>("Naziv");

                    b.HasKey("ID");

                    b.ToTable("Proizvodi");
                });

            modelBuilder.Entity("Forma.Data.Model.ProizvodiNadrudzbe", b =>
                {
                    b.Property<int>("NarudzbaId");

                    b.Property<int?>("ProizvodId");

                    b.Property<decimal>("Kolicina");

                    b.HasKey("NarudzbaId", "ProizvodId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("ProizvodiNadrudzbe");
                });

            modelBuilder.Entity("Forma.Data.Model.ProizvodiNadrudzbe", b =>
                {
                    b.HasOne("Forma.Data.Model.Narudzbe", "Narudzba")
                        .WithMany("Proizvodi")
                        .HasForeignKey("NarudzbaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Forma.Data.Model.ProizvodModel", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}