﻿// <auto-generated />
using System;
using ApiIntro.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiIntro.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231219133708_asddasd")]
    partial class asddasd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiIntro.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("brandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("ApiIntro.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorID")
                        .HasColumnType("int");

                    b.Property<double>("DailyPrice")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModelYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorID");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("ApiIntro.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("colorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("colors");
                });

            modelBuilder.Entity("ApiIntro.Entities.Car", b =>
                {
                    b.HasOne("ApiIntro.Entities.Brand", "brand")
                        .WithMany("brands")
                        .HasForeignKey("BrandId");

                    b.HasOne("ApiIntro.Entities.Color", "color")
                        .WithMany("colors")
                        .HasForeignKey("ColorID");

                    b.Navigation("brand");

                    b.Navigation("color");
                });

            modelBuilder.Entity("ApiIntro.Entities.Brand", b =>
                {
                    b.Navigation("brands");
                });

            modelBuilder.Entity("ApiIntro.Entities.Color", b =>
                {
                    b.Navigation("colors");
                });
#pragma warning restore 612, 618
        }
    }
}