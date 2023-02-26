﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepairShop.Domain.Model;

#nullable disable

namespace RepairShop.Domain.Migrations
{
    [DbContext(typeof(RepairShopContext))]
    [Migration("20230226143640_Initial migration")]
    partial class Initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("PartRepair", b =>
                {
                    b.Property<int>("PartsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RepairsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PartsId", "RepairsId");

                    b.HasIndex("RepairsId");

                    b.ToTable("PartRepair");

                    b.HasData(
                        new
                        {
                            PartsId = 1,
                            RepairsId = 1
                        },
                        new
                        {
                            PartsId = 2,
                            RepairsId = 2
                        },
                        new
                        {
                            PartsId = 3,
                            RepairsId = 2
                        },
                        new
                        {
                            PartsId = 4,
                            RepairsId = 3
                        },
                        new
                        {
                            PartsId = 5,
                            RepairsId = 5
                        },
                        new
                        {
                            PartsId = 6,
                            RepairsId = 6
                        },
                        new
                        {
                            PartsId = 7,
                            RepairsId = 7
                        },
                        new
                        {
                            PartsId = 8,
                            RepairsId = 8
                        });
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("StockNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Parts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Brake Pads",
                            Price = 29.99m,
                            StockNumber = "BP001"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Engine Oil",
                            Price = 62.99m,
                            StockNumber = "OIL4Q"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Oil Filter",
                            Price = 15.99m,
                            StockNumber = "OF001"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tires (4)",
                            Price = 400.00m,
                            StockNumber = "TR001"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Head Gasket",
                            Price = 35.00m,
                            StockNumber = "HG001"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Radio",
                            Price = 350.00m,
                            StockNumber = "RD001"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Transmission Rebuild Kit",
                            Price = 375.00m,
                            StockNumber = "TR001"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Muffler",
                            Price = 400m,
                            StockNumber = "MFL01"
                        });
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LaborTotal")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PartTotal")
                        .HasColumnType("TEXT");

                    b.Property<int>("RepairOrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RepairOrderId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.Repair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Labor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("RepairOrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RepairOrderId");

                    b.ToTable("Repairs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Maint",
                            Code = "BS001",
                            Labor = 2.0m,
                            Name = "Brake Service"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Maint",
                            Code = "OC001",
                            Labor = 0.5m,
                            Name = "Oil Change"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Maint",
                            Code = "TC001",
                            Labor = 1.5m,
                            Name = "Tire Change"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Maint",
                            Code = "TRB01",
                            Labor = 1.0m,
                            Name = "Tire Rotation & Balance"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Engine",
                            Code = "NG001",
                            Labor = 1.5m,
                            Name = "Replace head gasket"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Infotainment",
                            Code = "RR001",
                            Labor = 1.0m,
                            Name = "Replace radio"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Trans",
                            Code = "TR001",
                            Labor = 6.0m,
                            Name = "Transmission rebuild"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Emissions",
                            Code = "MR001",
                            Labor = 1.0m,
                            Name = "Muffler Replacement"
                        });
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.RepairOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehicleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("RepairOrders");
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Odometer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("PartRepair", b =>
                {
                    b.HasOne("RepairShop.Domain.Model.Entities.Part", null)
                        .WithMany()
                        .HasForeignKey("PartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RepairShop.Domain.Model.Entities.Repair", null)
                        .WithMany()
                        .HasForeignKey("RepairsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.Quote", b =>
                {
                    b.HasOne("RepairShop.Domain.Model.Entities.RepairOrder", "RepairOrder")
                        .WithMany()
                        .HasForeignKey("RepairOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RepairOrder");
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.Repair", b =>
                {
                    b.HasOne("RepairShop.Domain.Model.Entities.RepairOrder", null)
                        .WithMany("Repairs")
                        .HasForeignKey("RepairOrderId");
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.RepairOrder", b =>
                {
                    b.HasOne("RepairShop.Domain.Model.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.Vehicle", b =>
                {
                    b.HasOne("RepairShop.Domain.Model.Entities.Customer", "Customer")
                        .WithMany("Vehicles")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.Customer", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("RepairShop.Domain.Model.Entities.RepairOrder", b =>
                {
                    b.Navigation("Repairs");
                });
#pragma warning restore 612, 618
        }
    }
}
