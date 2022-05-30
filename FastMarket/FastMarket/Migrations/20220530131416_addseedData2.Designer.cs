﻿// <auto-generated />
using FastMarket.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FastMarket.Migrations
{
    [DbContext(typeof(FastMarketDBContext))]
    [Migration("20220530131416_addseedData2")]
    partial class addseedData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FastMarket.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<decimal>("totalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("FastMarket.Models.CartProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CartId");

                    b.HasIndex("CartId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("FastMarket.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Details = "Beauty Category contain multiple product like Blushes,Foundation,Gloss....",
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = 2,
                            Details = "Clothes Category contain multiple product like jeens,T-shirt,dress....",
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = 3,
                            Details = "Mobiles Category contain multiple product like IPhones,Samsung,Nokia....",
                            Name = "Mobiles"
                        },
                        new
                        {
                            Id = 4,
                            Details = "Computers & accessories Category contain multiple product like PC,Labtop,Headphones....",
                            Name = "Computers & accessories"
                        },
                        new
                        {
                            Id = 5,
                            Details = "TV & Home Entertainmen Category contain multiple product like DishTV HD,Samsung TV, LG",
                            Name = "TV & Home Entertainment"
                        },
                        new
                        {
                            Id = 6,
                            Details = "Furniture Category contain multiple product like Beds ,Beds Covers, Sofa",
                            Name = "Furniture"
                        });
                });

            modelBuilder.Entity("FastMarket.Models.CategoriesProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoriesProducts");

                    b.HasData(
                        new
                        {
                            CategoriesId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductId = 4
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductId = 6
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductId = 7
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductId = 8
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductId = 9
                        },
                        new
                        {
                            CategoriesId = 5,
                            ProductId = 10
                        });
                });

            modelBuilder.Entity("FastMarket.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 150,
                            Description = "Maybelline New York Colossal Bold Liner & Colossal Kajal - EYE KIT COMBO (Pack Of 2), 0.35 gm + 3 ml",
                            Name = "Liner & Colossal Kajal",
                            Price = 15.5m
                        },
                        new
                        {
                            Id = 2,
                            Amount = 120,
                            Description = "URBANMAC Premium Synthetic Kabuki Foundation Face Powder Blush Eyeshadow Brush Makeup Brush Kit with Blender Sponge and Brush Cleaner - Makeup Brushes Set",
                            Name = "Blushes",
                            Price = 20.00m
                        },
                        new
                        {
                            Id = 3,
                            Amount = 250,
                            Description = "Coloressence Full Coverage Waterproof Lightweight Matte Formula Opaque Lotion High Definition Foundation (HDF-2) with Set of 2 Blending Sponge",
                            Name = "Foundation ",
                            Price = 50.00m
                        },
                        new
                        {
                            Id = 4,
                            Amount = 60,
                            Description = "Wiffy Concealer Base Palette 15 In 1 Cream Kit Concealer",
                            Name = "Concealer ",
                            Price = 35.00m
                        },
                        new
                        {
                            Id = 5,
                            Amount = 30,
                            Description = "Description1",
                            Name = "Product1",
                            Price = 100m
                        },
                        new
                        {
                            Id = 6,
                            Amount = 40,
                            Description = "Description2",
                            Name = "Product2",
                            Price = 350m
                        },
                        new
                        {
                            Id = 7,
                            Amount = 50,
                            Description = "Description3",
                            Name = "Product3",
                            Price = 200m
                        },
                        new
                        {
                            Id = 8,
                            Amount = 60,
                            Description = "Description4",
                            Name = "Product4",
                            Price = 230m
                        },
                        new
                        {
                            Id = 9,
                            Amount = 70,
                            Description = "Description5",
                            Name = "Product5",
                            Price = 105m
                        },
                        new
                        {
                            Id = 10,
                            Amount = 70,
                            Description = "Description10",
                            Name = "Product10",
                            Price = 105m
                        });
                });

            modelBuilder.Entity("FastMarket.Models.CartProduct", b =>
                {
                    b.HasOne("FastMarket.Models.Cart", "Cart")
                        .WithMany("cartProducts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastMarket.Models.Product", "Product")
                        .WithMany("cartProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FastMarket.Models.CategoriesProduct", b =>
                {
                    b.HasOne("FastMarket.Models.Categories", "Categories")
                        .WithMany("categoriesProducts")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastMarket.Models.Product", "Product")
                        .WithMany("categoriesProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FastMarket.Models.Cart", b =>
                {
                    b.Navigation("cartProducts");
                });

            modelBuilder.Entity("FastMarket.Models.Categories", b =>
                {
                    b.Navigation("categoriesProducts");
                });

            modelBuilder.Entity("FastMarket.Models.Product", b =>
                {
                    b.Navigation("cartProducts");

                    b.Navigation("categoriesProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
