﻿// <auto-generated />
using System;
using BakeryApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BakeryApp.DataAccess.Migrations
{
    [DbContext(typeof(BakeryContext))]
    [Migration("20230412150000_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BakeryApp.Model.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Recipes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ingredients"
                        },
                        new
                        {
                            Id = 3,
                            Name = "MenuItem"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dairy",
                            ParentCategoryId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Sweetener",
                            ParentCategoryId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Flour",
                            ParentCategoryId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Pastry",
                            ParentCategoryId = 3
                        },
                        new
                        {
                            Id = 8,
                            Name = "Beverage",
                            ParentCategoryId = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Sandwich",
                            ParentCategoryId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Cake",
                            ParentCategoryId = 3
                        },
                        new
                        {
                            Id = 11,
                            Name = "Cookie",
                            ParentCategoryId = 3
                        },
                        new
                        {
                            Id = 12,
                            Name = "Brownie",
                            ParentCategoryId = 3
                        },
                        new
                        {
                            Id = 13,
                            Name = "Pastry cream",
                            ParentCategoryId = 3
                        },
                        new
                        {
                            Id = 14,
                            Name = "Fruit",
                            ParentCategoryId = 2
                        });
                });

            modelBuilder.Entity("BakeryApp.Model.Models.Ingredient", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 4,
                            Name = "Butter"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 4,
                            Name = "Milk"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 5,
                            Name = "Sugar"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Name = "Brown Sugar"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 6,
                            Name = "Flour"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 6,
                            Name = "StrawBerry"
                        });
                });

            modelBuilder.Entity("BakeryApp.Model.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("BakeryApp.Model.Models.MenuItemRecipes", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.HasKey("RecipeId", "MenuItemId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("MenuItemRecipes");
                });

            modelBuilder.Entity("BakeryApp.Model.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 12,
                            Name = "Brownie"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 10,
                            Name = "Sponge Cake"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 11,
                            Name = "Chocolate chip cookie"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 13,
                            Name = "Butter Cream"
                        });
                });

            modelBuilder.Entity("BakeryApp.Model.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("recipeIngredients");

                    b.HasData(
                        new
                        {
                            RecipeId = 2,
                            IngredientId = 1,
                            Amount = 0,
                            Unit = "20g"
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 3,
                            Amount = 0,
                            Unit = "1cup"
                        },
                        new
                        {
                            RecipeId = 4,
                            IngredientId = 5,
                            Amount = 0,
                            Unit = "2cups"
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 5,
                            Amount = 0,
                            Unit = "2cups"
                        });
                });

            modelBuilder.Entity("BakeryApp.Model.Models.Ingredient", b =>
                {
                    b.HasOne("BakeryApp.Model.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BakeryApp.Model.Models.MenuItemRecipes", b =>
                {
                    b.HasOne("BakeryApp.Model.Models.MenuItem", "MenuItem")
                        .WithMany("MenuItemRecipes")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BakeryApp.Model.Models.Recipe", "Recipe")
                        .WithMany("MenuItemRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("BakeryApp.Model.Models.Recipe", b =>
                {
                    b.HasOne("BakeryApp.Model.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BakeryApp.Model.Models.MenuItem", null)
                        .WithMany("Recipes")
                        .HasForeignKey("MenuItemId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BakeryApp.Model.Models.RecipeIngredient", b =>
                {
                    b.HasOne("BakeryApp.Model.Models.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BakeryApp.Model.Models.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("BakeryApp.Model.Models.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("BakeryApp.Model.Models.MenuItem", b =>
                {
                    b.Navigation("MenuItemRecipes");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("BakeryApp.Model.Models.Recipe", b =>
                {
                    b.Navigation("MenuItemRecipes");

                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}