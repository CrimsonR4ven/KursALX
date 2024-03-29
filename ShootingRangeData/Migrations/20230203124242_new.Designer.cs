﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShootingRangeData.ShootingRangeDB;

#nullable disable

namespace ShootingRangeData.Migrations
{
    [DbContext(typeof(ShootingRangeContext))]
    [Migration("20230203124242_new")]
    partial class @new
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BundleGun", b =>
                {
                    b.Property<Guid>("BundlesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GunsID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BundlesID", "GunsID");

                    b.HasIndex("GunsID");

                    b.ToTable("BundleGun");
                });

            modelBuilder.Entity("ShootingRangeData.ShootingRangeDB.Bundle", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Bundles");
                });

            modelBuilder.Entity("ShootingRangeData.ShootingRangeDB.Gun", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImgName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("LaneID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("LaneID");

                    b.HasIndex("Name");

                    b.HasIndex("Price");

                    b.ToTable("Guns");
                });

            modelBuilder.Entity("ShootingRangeData.ShootingRangeDB.GunCategory", b =>
                {
                    b.Property<Guid>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryID");

                    b.HasIndex("Name");

                    b.ToTable("GunCategories");
                });

            modelBuilder.Entity("ShootingRangeData.ShootingRangeDB.GunLane", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("LaneID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("RentPrice")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("LaneID");

                    b.ToTable("Lanes");
                });

            modelBuilder.Entity("ShootingRangeData.ShootingRangeDB.GunLaneType", b =>
                {
                    b.Property<Guid>("LaneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("LaneID");

                    b.ToTable("LaneTypes");
                });

            modelBuilder.Entity("BundleGun", b =>
                {
                    b.HasOne("ShootingRangeData.ShootingRangeDB.Bundle", null)
                        .WithMany()
                        .HasForeignKey("BundlesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShootingRangeData.ShootingRangeDB.Gun", null)
                        .WithMany()
                        .HasForeignKey("GunsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShootingRangeData.ShootingRangeDB.Gun", b =>
                {
                    b.HasOne("ShootingRangeData.ShootingRangeDB.GunCategory", "Category")
                        .WithMany("Guns")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShootingRangeData.ShootingRangeDB.GunLaneType", "Lane")
                        .WithMany("Guns")
                        .HasForeignKey("LaneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Lane");
                });

            modelBuilder.Entity("ShootingRangeData.ShootingRangeDB.GunLane", b =>
                {
                    b.HasOne("ShootingRangeData.ShootingRangeDB.GunLaneType", "Lane")
                        .WithMany("GunLanes")
                        .HasForeignKey("LaneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lane");
                });

            modelBuilder.Entity("ShootingRangeData.ShootingRangeDB.GunCategory", b =>
                {
                    b.Navigation("Guns");
                });

            modelBuilder.Entity("ShootingRangeData.ShootingRangeDB.GunLaneType", b =>
                {
                    b.Navigation("GunLanes");

                    b.Navigation("Guns");
                });
#pragma warning restore 612, 618
        }
    }
}
