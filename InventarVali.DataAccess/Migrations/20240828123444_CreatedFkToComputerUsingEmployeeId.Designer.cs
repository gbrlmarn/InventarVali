﻿// <auto-generated />
using System;
using InventarVali.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InventarVali.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240828123444_CreatedFkToComputerUsingEmployeeId")]
    partial class CreatedFkToComputerUsingEmployeeId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InventarVali.Models.Autovehicule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<bool?>("HasITP")
                        .IsRequired()
                        .HasColumnType("boolean");

                    b.Property<bool?>("HasVinieta")
                        .IsRequired()
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ITPExpirationDate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<DateTime?>("InsuranceExpirationDate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("InsurenceDate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VinNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("VinietaExpirationDate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Autovehicule");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            HasITP = true,
                            HasVinieta = true,
                            ITPExpirationDate = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            InsuranceExpirationDate = new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc),
                            InsurenceDate = new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc),
                            LicensePlate = "B 06 CAR",
                            Type = "Duba",
                            VinNumber = "1XPWDBTX48D766660",
                            VinietaExpirationDate = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            HasITP = false,
                            HasVinieta = false,
                            ITPExpirationDate = new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            InsuranceExpirationDate = new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc),
                            InsurenceDate = new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            LicensePlate = "CL 06 PLM",
                            Type = "Audi R8",
                            VinNumber = "1XPWDBTX48D766660",
                            VinietaExpirationDate = new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("InventarVali.Models.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Computers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Intel Core I9, RTX 4070, 32 GB RAM",
                            EmployeeId = 2,
                            ImageUrl = "",
                            Model = "Asus Rog",
                            SerialNumber = "12-12AB3",
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Intel Core I5, no GPU, 32 GB RAM",
                            EmployeeId = 1,
                            ImageUrl = "",
                            Model = "x570 Aorus Elite",
                            Type = "Desktop"
                        });
                });

            modelBuilder.Entity("InventarVali.Models.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "test@email.com",
                            FirstName = "John",
                            FullName = "John Doe",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Email = "test2@email.com",
                            FirstName = "Michael",
                            FullName = "Michael Cox",
                            LastName = "Cox"
                        },
                        new
                        {
                            Id = 3,
                            Email = "test4@email.com",
                            FirstName = "Vasile",
                            FullName = "Vasile Braconieru",
                            LastName = "Braconieru"
                        });
                });

            modelBuilder.Entity("InventarVali.Models.Goods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsTaken")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Goods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "",
                            IsTaken = true,
                            Name = "Masina",
                            Type = "Dacia Duster"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "",
                            IsTaken = false,
                            Name = "Masina",
                            Type = "Audi A6"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "",
                            IsTaken = true,
                            Name = "Laptop",
                            Type = "Asus Rog"
                        });
                });

            modelBuilder.Entity("InventarVali.Models.Autovehicule", b =>
                {
                    b.HasOne("InventarVali.Models.Employees", "Employees")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("InventarVali.Models.Computer", b =>
                {
                    b.HasOne("InventarVali.Models.Employees", "Employees")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
