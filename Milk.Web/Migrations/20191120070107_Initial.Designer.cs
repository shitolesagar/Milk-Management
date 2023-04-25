﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Milk.Web;

namespace Milk.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191120070107_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Milk.Web.Models.Advance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("FarmerId");

                    b.HasKey("Id");

                    b.HasIndex("FarmerId");

                    b.ToTable("Advance");
                });

            modelBuilder.Entity("Milk.Web.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("Milk.Web.Models.Farmer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name");

                    b.Property<string>("ProfilePicture");

                    b.Property<string>("Village");

                    b.HasKey("Id");

                    b.ToTable("Farmer");
                });

            modelBuilder.Entity("Milk.Web.Models.Feed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("FarmerId");

                    b.HasKey("Id");

                    b.HasIndex("FarmerId");

                    b.ToTable("Feed");
                });

            modelBuilder.Entity("Milk.Web.Models.MilkEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<float>("FAT");

                    b.Property<int>("FarmerId");

                    b.Property<float>("Milk");

                    b.Property<float>("SNF");

                    b.HasKey("Id");

                    b.HasIndex("FarmerId");

                    b.ToTable("MilkEntry");
                });

            modelBuilder.Entity("Milk.Web.Models.RateChart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("FAT");

                    b.Property<float>("Rate");

                    b.Property<float>("SNF");

                    b.HasKey("Id");

                    b.ToTable("RateChart");
                });

            modelBuilder.Entity("Milk.Web.Models.Advance", b =>
                {
                    b.HasOne("Milk.Web.Models.Farmer", "Farmer")
                        .WithMany("Advances")
                        .HasForeignKey("FarmerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Milk.Web.Models.Feed", b =>
                {
                    b.HasOne("Milk.Web.Models.Farmer", "Farmer")
                        .WithMany("Feeds")
                        .HasForeignKey("FarmerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Milk.Web.Models.MilkEntry", b =>
                {
                    b.HasOne("Milk.Web.Models.Farmer", "Farmer")
                        .WithMany("MilkEntries")
                        .HasForeignKey("FarmerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
