﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortfolioEndpoint.Data;

namespace PortfolioEndpoint.Migrations
{
    [DbContext(typeof(PortfolioEndpointContext))]
    [Migration("20200615145327_removingForignKeys")]
    partial class removingForignKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PortfolioEndpoint.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChangeAlert")
                        .HasColumnType("int");

                    b.Property<double>("InitialPrice")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("LastAlertPrice")
                        .HasColumnType("float");

                    b.Property<int>("SymbolId")
                        .HasColumnType("int");

                    b.Property<double?>("TargetPrice")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChangeAlert = 5,
                            InitialPrice = 1234.0,
                            IsActive = true,
                            LastAlertPrice = 1234.0,
                            SymbolId = 1,
                            TargetPrice = 1235.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ChangeAlert = 5,
                            InitialPrice = 1234.0,
                            IsActive = true,
                            LastAlertPrice = 1234.0,
                            SymbolId = 2,
                            TargetPrice = 1235.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            ChangeAlert = 1,
                            InitialPrice = 4321.0,
                            IsActive = true,
                            LastAlertPrice = 4321.0,
                            SymbolId = 1,
                            TargetPrice = 4322.0,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("PortfolioEndpoint.Models.Symbol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ticker")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Symbols");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tesla",
                            Ticker = "TSLA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "PayPoint PLC",
                            Ticker = "PAY.L"
                        });
                });

            modelBuilder.Entity("PortfolioEndpoint.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastContact")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelegramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Carson",
                            LastContact = new DateTime(2020, 6, 15, 15, 53, 26, 635, DateTimeKind.Local).AddTicks(2921),
                            LastName = "Alexander",
                            TelegramId = 0
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Meredith",
                            LastContact = new DateTime(2020, 6, 15, 15, 53, 26, 640, DateTimeKind.Local).AddTicks(144),
                            LastName = "Alonso",
                            TelegramId = 0
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Arturo",
                            LastContact = new DateTime(2020, 6, 15, 15, 53, 26, 640, DateTimeKind.Local).AddTicks(229),
                            LastName = "Anand",
                            TelegramId = 0
                        });
                });

            modelBuilder.Entity("PortfolioEndpoint.Models.Stock", b =>
                {
                    b.HasOne("PortfolioEndpoint.Models.User", "User")
                        .WithMany("Stocks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
