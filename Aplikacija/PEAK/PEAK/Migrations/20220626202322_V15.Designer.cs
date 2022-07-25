﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PEAK.Data;

namespace PEAK.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220626202322_V15")]
    partial class V15
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("ApplicationUserApplicationUser", b =>
                {
                    b.Property<string>("PratiId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PratiteljId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("PratiId", "PratiteljId");

                    b.HasIndex("PratiteljId");

                    b.ToTable("ApplicationUserApplicationUser");
                });

            modelBuilder.Entity("ApplicationUserDogadjaj", b =>
                {
                    b.Property<int>("DogadjajiID")
                        .HasColumnType("int");

                    b.Property<string>("KorisniciId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("DogadjajiID", "KorisniciId");

                    b.HasIndex("KorisniciId");

                    b.ToTable("ApplicationUserDogadjaj");
                });

            modelBuilder.Entity("ApplicationUserObavestenje", b =>
                {
                    b.Property<string>("KorisniciId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ObavestenjaID")
                        .HasColumnType("int");

                    b.HasKey("KorisniciId", "ObavestenjaID");

                    b.HasIndex("ObavestenjaID");

                    b.ToTable("ApplicationUserObavestenje");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("LokacijaRuta", b =>
                {
                    b.Property<int>("LokacijeID")
                        .HasColumnType("int");

                    b.Property<int>("RuteID")
                        .HasColumnType("int");

                    b.HasKey("LokacijeID", "RuteID");

                    b.HasIndex("RuteID");

                    b.ToTable("LokacijaRuta");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PEAK.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Ime")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("PlaninarskoDrustvoID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("longtext");

                    b.Property<bool>("Prihvacen")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProfilnaSlika")
                        .HasColumnType("longtext");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<int>("Spremnost")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("PlaninarskoDrustvoID");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PEAK.Models.Dogadjaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.Property<int?>("OrganizatorID")
                        .HasColumnType("int");

                    b.Property<int?>("RutaID")
                        .HasColumnType("int");

                    b.Property<string>("SlikaDogadjaja")
                        .HasColumnType("longtext");

                    b.Property<string>("Tip")
                        .HasColumnType("longtext");

                    b.Property<bool>("potvrdjen")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.HasIndex("OrganizatorID");

                    b.HasIndex("RutaID");

                    b.ToTable("Dogadjaji");
                });

            modelBuilder.Entity("PEAK.Models.Interesovanje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Mesto")
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Tip")
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<int>("Udaljenost")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Interesovanja");
                });

            modelBuilder.Entity("PEAK.Models.Lokacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Visina")
                        .HasColumnType("int");

                    b.Property<float>("XCord")
                        .HasColumnType("float");

                    b.Property<float>("YCord")
                        .HasColumnType("float");

                    b.Property<bool>("potvrdjena")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("Lokacije");
                });

            modelBuilder.Entity("PEAK.Models.Obavestenje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DrustvoID")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("longtext");

                    b.Property<string>("Tekst")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("DrustvoID");

                    b.ToTable("Obavestenja");
                });

            modelBuilder.Entity("PEAK.Models.Objava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DrustvoID")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("longtext");

                    b.Property<string>("Tekst")
                        .HasColumnType("longtext");

                    b.Property<string>("Tip")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("DrustvoID");

                    b.ToTable("Objave");
                });

            modelBuilder.Entity("PEAK.Models.Planina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.Property<bool>("Odobrena")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SlikaPlanine")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Planine");
                });

            modelBuilder.Entity("PEAK.Models.PlaninarskoDrustvo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("BrojClanova")
                        .HasColumnType("int");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("longtext");

                    b.Property<int>("Clanarina")
                        .HasColumnType("int");

                    b.Property<bool>("Kreirano")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NalogDrustvaId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.Property<string>("SlikaDrustva")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("NalogDrustvaId")
                        .IsUnique();

                    b.ToTable("PlaninarskaDrustva");
                });

            modelBuilder.Entity("PEAK.Models.PrijavaDogadjaja", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DogadjajID")
                        .HasColumnType("int");

                    b.Property<string>("KorisnikId")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("LokacijaID")
                        .HasColumnType("int");

                    b.Property<string>("Razlog")
                        .HasColumnType("longtext");

                    b.Property<int?>("UtisakID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DogadjajID");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("LokacijaID");

                    b.HasIndex("UtisakID");

                    b.ToTable("PrijaveDogadjaja");
                });

            modelBuilder.Entity("PEAK.Models.PrijavaLokacije", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KorisnikId")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("LokacijaID")
                        .HasColumnType("int");

                    b.Property<string>("Razlog")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("LokacijaID");

                    b.ToTable("PrijaveLokacije");
                });

            modelBuilder.Entity("PEAK.Models.PrijavaUtiska", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KorisnikId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Razlog")
                        .HasColumnType("longtext");

                    b.Property<int?>("UtisakID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UtisakID");

                    b.ToTable("PrijaveUtisaka");
                });

            modelBuilder.Entity("PEAK.Models.Prognoza", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Oblacnost")
                        .HasColumnType("int");

                    b.Property<int>("Temperatura")
                        .HasColumnType("int");

                    b.Property<int>("VerovatnocaPadavina")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prognoza");
                });

            modelBuilder.Entity("PEAK.Models.Ruta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Duzina")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PlaninaID")
                        .HasColumnType("int");

                    b.Property<int>("Tezina")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PlaninaID");

                    b.ToTable("Ruta");
                });

            modelBuilder.Entity("PEAK.Models.Utisak", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DogadjajID")
                        .HasColumnType("int");

                    b.Property<int?>("DrustvoID")
                        .HasColumnType("int");

                    b.Property<string>("Komentar")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("KorisnikId")
                        .HasColumnType("varchar(255)");

                    b.Property<float>("Ocena")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("DogadjajID");

                    b.HasIndex("DrustvoID");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Utisci");
                });

            modelBuilder.Entity("PEAK.Models.Vrh", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.Property<int?>("PlaninaID")
                        .HasColumnType("int");

                    b.Property<int>("Visina")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PlaninaID");

                    b.ToTable("Vrhovi");
                });

            modelBuilder.Entity("ApplicationUserApplicationUser", b =>
                {
                    b.HasOne("PEAK.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("PratiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PEAK.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("PratiteljId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationUserDogadjaj", b =>
                {
                    b.HasOne("PEAK.Models.Dogadjaj", null)
                        .WithMany()
                        .HasForeignKey("DogadjajiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PEAK.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("KorisniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationUserObavestenje", b =>
                {
                    b.HasOne("PEAK.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("KorisniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PEAK.Models.Obavestenje", null)
                        .WithMany()
                        .HasForeignKey("ObavestenjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LokacijaRuta", b =>
                {
                    b.HasOne("PEAK.Models.Lokacija", null)
                        .WithMany()
                        .HasForeignKey("LokacijeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PEAK.Models.Ruta", null)
                        .WithMany()
                        .HasForeignKey("RuteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("PEAK.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PEAK.Models.ApplicationUser", null)
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

                    b.HasOne("PEAK.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PEAK.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PEAK.Models.ApplicationUser", b =>
                {
                    b.HasOne("PEAK.Models.PlaninarskoDrustvo", "PlaninarskoDrustvo")
                        .WithMany("Clanovi")
                        .HasForeignKey("PlaninarskoDrustvoID");

                    b.Navigation("PlaninarskoDrustvo");
                });

            modelBuilder.Entity("PEAK.Models.Dogadjaj", b =>
                {
                    b.HasOne("PEAK.Models.PlaninarskoDrustvo", "Organizator")
                        .WithMany("Dogadjaji")
                        .HasForeignKey("OrganizatorID");

                    b.HasOne("PEAK.Models.Ruta", "Ruta")
                        .WithMany("Dogadjaji")
                        .HasForeignKey("RutaID");

                    b.Navigation("Organizator");

                    b.Navigation("Ruta");
                });

            modelBuilder.Entity("PEAK.Models.Interesovanje", b =>
                {
                    b.HasOne("PEAK.Models.ApplicationUser", null)
                        .WithMany("Interesovanja")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("PEAK.Models.Obavestenje", b =>
                {
                    b.HasOne("PEAK.Models.PlaninarskoDrustvo", "Drustvo")
                        .WithMany("Obavestenja")
                        .HasForeignKey("DrustvoID");

                    b.Navigation("Drustvo");
                });

            modelBuilder.Entity("PEAK.Models.Objava", b =>
                {
                    b.HasOne("PEAK.Models.PlaninarskoDrustvo", "Drustvo")
                        .WithMany("Objave")
                        .HasForeignKey("DrustvoID");

                    b.Navigation("Drustvo");
                });

            modelBuilder.Entity("PEAK.Models.PlaninarskoDrustvo", b =>
                {
                    b.HasOne("PEAK.Models.ApplicationUser", "NalogDrustva")
                        .WithOne("UpravljaDrustvom")
                        .HasForeignKey("PEAK.Models.PlaninarskoDrustvo", "NalogDrustvaId");

                    b.Navigation("NalogDrustva");
                });

            modelBuilder.Entity("PEAK.Models.PrijavaDogadjaja", b =>
                {
                    b.HasOne("PEAK.Models.Dogadjaj", "Dogadjaj")
                        .WithMany("Prijave")
                        .HasForeignKey("DogadjajID");

                    b.HasOne("PEAK.Models.ApplicationUser", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");

                    b.HasOne("PEAK.Models.Lokacija", null)
                        .WithMany("Prijave")
                        .HasForeignKey("LokacijaID");

                    b.HasOne("PEAK.Models.Utisak", null)
                        .WithMany("Prijave")
                        .HasForeignKey("UtisakID");

                    b.Navigation("Dogadjaj");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("PEAK.Models.PrijavaLokacije", b =>
                {
                    b.HasOne("PEAK.Models.ApplicationUser", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");

                    b.HasOne("PEAK.Models.Lokacija", "Lokacija")
                        .WithMany()
                        .HasForeignKey("LokacijaID");

                    b.Navigation("Korisnik");

                    b.Navigation("Lokacija");
                });

            modelBuilder.Entity("PEAK.Models.PrijavaUtiska", b =>
                {
                    b.HasOne("PEAK.Models.ApplicationUser", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");

                    b.HasOne("PEAK.Models.Utisak", "Utisak")
                        .WithMany("PrijavaUtiska")
                        .HasForeignKey("UtisakID");

                    b.Navigation("Korisnik");

                    b.Navigation("Utisak");
                });

            modelBuilder.Entity("PEAK.Models.Prognoza", b =>
                {
                    b.HasOne("PEAK.Models.Dogadjaj", "Dogadjaj")
                        .WithOne("Prognoza")
                        .HasForeignKey("PEAK.Models.Prognoza", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dogadjaj");
                });

            modelBuilder.Entity("PEAK.Models.Ruta", b =>
                {
                    b.HasOne("PEAK.Models.Planina", "Planina")
                        .WithMany("Rute")
                        .HasForeignKey("PlaninaID");

                    b.Navigation("Planina");
                });

            modelBuilder.Entity("PEAK.Models.Utisak", b =>
                {
                    b.HasOne("PEAK.Models.Dogadjaj", "Dogadjaj")
                        .WithMany("Utisci")
                        .HasForeignKey("DogadjajID");

                    b.HasOne("PEAK.Models.PlaninarskoDrustvo", "Drustvo")
                        .WithMany("Utisci")
                        .HasForeignKey("DrustvoID");

                    b.HasOne("PEAK.Models.ApplicationUser", "Korisnik")
                        .WithMany("Utisci")
                        .HasForeignKey("KorisnikId");

                    b.Navigation("Dogadjaj");

                    b.Navigation("Drustvo");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("PEAK.Models.Vrh", b =>
                {
                    b.HasOne("PEAK.Models.Planina", "Planina")
                        .WithMany("Vrhovi")
                        .HasForeignKey("PlaninaID");

                    b.Navigation("Planina");
                });

            modelBuilder.Entity("PEAK.Models.ApplicationUser", b =>
                {
                    b.Navigation("Interesovanja");

                    b.Navigation("UpravljaDrustvom");

                    b.Navigation("Utisci");
                });

            modelBuilder.Entity("PEAK.Models.Dogadjaj", b =>
                {
                    b.Navigation("Prijave");

                    b.Navigation("Prognoza");

                    b.Navigation("Utisci");
                });

            modelBuilder.Entity("PEAK.Models.Lokacija", b =>
                {
                    b.Navigation("Prijave");
                });

            modelBuilder.Entity("PEAK.Models.Planina", b =>
                {
                    b.Navigation("Rute");

                    b.Navigation("Vrhovi");
                });

            modelBuilder.Entity("PEAK.Models.PlaninarskoDrustvo", b =>
                {
                    b.Navigation("Clanovi");

                    b.Navigation("Dogadjaji");

                    b.Navigation("Obavestenja");

                    b.Navigation("Objave");

                    b.Navigation("Utisci");
                });

            modelBuilder.Entity("PEAK.Models.Ruta", b =>
                {
                    b.Navigation("Dogadjaji");
                });

            modelBuilder.Entity("PEAK.Models.Utisak", b =>
                {
                    b.Navigation("PrijavaUtiska");

                    b.Navigation("Prijave");
                });
#pragma warning restore 612, 618
        }
    }
}
