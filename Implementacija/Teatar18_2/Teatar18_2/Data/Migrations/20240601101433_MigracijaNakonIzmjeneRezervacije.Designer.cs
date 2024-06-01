﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teatar18_2.Data;

#nullable disable

namespace Teatar18_2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240601101433_MigracijaNakonIzmjeneRezervacije")]
    partial class MigracijaNakonIzmjeneRezervacije
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Karta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IDIzvedbe")
                        .HasColumnType("int");

                    b.Property<int?>("IDRezervacije")
                        .HasColumnType("int");

                    b.Property<double>("cijena")
                        .HasColumnType("float");

                    b.Property<bool>("placena")
                        .HasColumnType("bit");

                    b.Property<int>("sjediste")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDIzvedbe");

                    b.HasIndex("IDRezervacije");

                    b.ToTable("Karta", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Ocjena", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IDPredstave")
                        .HasColumnType("int");

                    b.Property<int>("ocjena")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDPredstave");

                    b.ToTable("Ocjena", (string)null);
                });

            modelBuilder.Entity("Teatar18_2.Models.Izvedba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IDPredstave")
                        .HasColumnType("int");

                    b.Property<int>("brojSlobodnihKarata")
                        .HasColumnType("int");

                    b.Property<DateTime>("vrijeme")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("IDPredstave");

                    b.ToTable("Izvedba", (string)null);
                });

            modelBuilder.Entity("Teatar18_2.Models.Korisnik", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("brojKupljenihKarata")
                        .HasColumnType("int");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("newsletter")
                        .HasColumnType("bit");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Teatar18_2.Models.Newsletter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("datumSlanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("informacija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Newsletter", (string)null);
                });

            modelBuilder.Entity("Teatar18_2.Models.Pitanje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("IDKorisnikaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IDZaposlenikaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("datumOdgovora")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumPostavljanja")
                        .HasColumnType("datetime2");

                    b.Property<bool>("odgovoreno")
                        .HasColumnType("bit");

                    b.Property<string>("predmet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sadrzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDKorisnikaId");

                    b.HasIndex("IDZaposlenikaId");

                    b.ToTable("Pitanje", (string)null);
                });

            modelBuilder.Entity("Teatar18_2.Models.Predstava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("glumci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("preporucena")
                        .HasColumnType("bit");

                    b.Property<string>("reziseri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scenaristi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scenografi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trajanje")
                        .HasColumnType("int");

                    b.Property<bool>("uRepertoaru")
                        .HasColumnType("bit");

                    b.Property<int>("zanr")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Predstava", (string)null);
                });

            modelBuilder.Entity("Teatar18_2.Models.Rezervacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("IDKorisnikaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("aktivna")
                        .HasColumnType("bit");

                    b.Property<int>("brojKarata")
                        .HasColumnType("int");

                    b.Property<bool>("kupovina")
                        .HasColumnType("bit");

                    b.Property<double>("popust")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("IDKorisnikaId");

                    b.ToTable("Rezervacija", (string)null);
                });

            modelBuilder.Entity("Karta", b =>
                {
                    b.HasOne("Teatar18_2.Models.Izvedba", "Izvedba")
                        .WithMany()
                        .HasForeignKey("IDIzvedbe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teatar18_2.Models.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("IDRezervacije");

                    b.Navigation("Izvedba");

                    b.Navigation("Rezervacija");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Teatar18_2.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Teatar18_2.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teatar18_2.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Teatar18_2.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ocjena", b =>
                {
                    b.HasOne("Teatar18_2.Models.Predstava", "Predstava")
                        .WithMany()
                        .HasForeignKey("IDPredstave")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predstava");
                });

            modelBuilder.Entity("Teatar18_2.Models.Izvedba", b =>
                {
                    b.HasOne("Teatar18_2.Models.Predstava", "Predstava")
                        .WithMany()
                        .HasForeignKey("IDPredstave")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predstava");
                });

            modelBuilder.Entity("Teatar18_2.Models.Pitanje", b =>
                {
                    b.HasOne("Teatar18_2.Models.Korisnik", "IDKorisnika")
                        .WithMany()
                        .HasForeignKey("IDKorisnikaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teatar18_2.Models.Korisnik", "IDZaposlenika")
                        .WithMany()
                        .HasForeignKey("IDZaposlenikaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IDKorisnika");

                    b.Navigation("IDZaposlenika");
                });

            modelBuilder.Entity("Teatar18_2.Models.Rezervacija", b =>
                {
                    b.HasOne("Teatar18_2.Models.Korisnik", "IDKorisnika")
                        .WithMany()
                        .HasForeignKey("IDKorisnikaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IDKorisnika");
                });
#pragma warning restore 612, 618
        }
    }
}