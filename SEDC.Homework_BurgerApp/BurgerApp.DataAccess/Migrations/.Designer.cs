﻿// <auto-generated />
using BurgerApp.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerApp.DataAccess.Migrations
{
    [DbContext(typeof(BurgerAppDbContext))]
    [Migration("20230721143606_AddedLocationModelv3")]
    partial class AddedLocationModelv3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BurgerApp.Domain.Models.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("HasFries")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVegan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Burgers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasFries = true,
                            ImageUrl = "",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Chicken Burger",
                            Price = 3
                        },
                        new
                        {
                            Id = 2,
                            HasFries = false,
                            ImageUrl = "",
                            IsVegan = false,
                            IsVegetarian = true,
                            Name = "Classic Veggie Burger",
                            Price = 4
                        },
                        new
                        {
                            Id = 3,
                            HasFries = false,
                            ImageUrl = "",
                            IsVegan = true,
                            IsVegetarian = false,
                            Name = "Portobello Mushroom Burger",
                            Price = 6
                        },
                        new
                        {
                            Id = 4,
                            HasFries = true,
                            ImageUrl = "",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Bacon Cheeseburger",
                            Price = 7
                        },
                        new
                        {
                            Id = 5,
                            HasFries = true,
                            ImageUrl = "",
                            IsVegan = true,
                            IsVegetarian = false,
                            Name = "Tofu Burger",
                            Price = 5
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.BurgerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BurgerId")
                        .HasColumnType("int");

                    b.Property<int>("BurgerSize")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BurgerId");

                    b.HasIndex("OrderId");

                    b.ToTable("BurgerOrder");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosesAt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpensAt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Metodija Shatorov-Sharlo 11",
                            ClosesAt = "00:00",
                            Name = "Equilibrium",
                            OpensAt = "09:00"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Vidoe Smilevski Bato 8",
                            ClosesAt = "01:00",
                            Name = "Equilibrium",
                            OpensAt = "09:30"
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Metodija Sharotov Sharlo 23/1",
                            FullName = "Stojadin Stojkov",
                            IsDelivered = false,
                            LocationId = 2
                        },
                        new
                        {
                            Id = 2,
                            Address = "Rilski Kongres 92",
                            FullName = "Petko Petkovski",
                            IsDelivered = false,
                            LocationId = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "Skopska Crna Gora",
                            FullName = "Trajanka Mileva",
                            IsDelivered = false,
                            LocationId = 1
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.BurgerOrder", b =>
                {
                    b.HasOne("BurgerApp.Domain.Models.Burger", "Burger")
                        .WithMany("BurgerOrders")
                        .HasForeignKey("BurgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerApp.Domain.Models.Order", "Order")
                        .WithMany("BurgerOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.HasOne("BurgerApp.Domain.Models.Location", "Location")
                        .WithMany("Orders")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Burger", b =>
                {
                    b.Navigation("BurgerOrders");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Location", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.Navigation("BurgerOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
