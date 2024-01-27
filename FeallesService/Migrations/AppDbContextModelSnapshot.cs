﻿// <auto-generated />
using System;
using FeallesService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FeallesService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FeallesService.Models.Feallesbase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adresser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AndreDataFraAnnoncen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AvisTypeID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Avisdato")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Begravelsesdato")
                        .HasColumnType("datetime2");

                    b.Property<string>("Begravelsessted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doebenavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Doedsdato")
                        .HasColumnType("datetime2");

                    b.Property<string>("Efterladte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Efternavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Erhverv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlereDoedsannoncer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Foedt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fornavne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Mindeord")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Nekrolog")
                        .HasColumnType("datetime2");

                    b.Property<string>("Oegenavne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Partnerlink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SognID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Statstidende")
                        .HasColumnType("datetime2");

                    b.Property<string>("TidlBopael")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Feallesbases");
                });
#pragma warning restore 612, 618
        }
    }
}
