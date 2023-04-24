using BakeryApp.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BakeryApp.DataAccess
{


    public class BakeryContext : DbContext
    {
        public BakeryContext(DbContextOptions<BakeryContext> options)
            : base(options)
        {
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=.;Database=Bakery;Trusted_Connection=True;TrustServerCertificate=True");
        //    }
        //}

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Ingredient> Ingredients{ get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RecipeIngredient> recipeIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<RecipeIngredient>()
              .HasKey(x => new { x.RecipeId, x.IngredientId});
            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(x => x.Recipe)
                .WithMany(x => x.RecipeIngredients)
                .HasForeignKey(x => x.RecipeId);
            modelBuilder.Entity<RecipeIngredient>()
               .HasOne(x => x.Ingredient)
               .WithMany(x => x.RecipeIngredients)
               .HasForeignKey(x => x.IngredientId);

            modelBuilder.Entity<MenuItemRecipes>()
            .HasKey(x => new { x.RecipeId, x.MenuItemId });
            modelBuilder.Entity<MenuItemRecipes>()
                .HasOne(x => x.Recipe)
                .WithMany(x => x.MenuItemRecipes)
                .HasForeignKey(x => x.RecipeId);
            modelBuilder.Entity<MenuItemRecipes>()
               .HasOne(x => x.MenuItem)
               .WithMany(x => x.MenuItemRecipes)
               .HasForeignKey(x => x.MenuItemId);

            modelBuilder.Entity<MenuItemIngredient>()
           .HasKey(x => new { x.IngredientId, x.MenuItemId });
            modelBuilder.Entity<MenuItemIngredient>()
                .HasOne(x => x.MenuItem)
                .WithMany(x => x.MenuItemIngredients)
                .HasForeignKey(x => x.MenuItemId);
            modelBuilder.Entity<MenuItemIngredient>()
               .HasOne(x => x.Ingredient)
               .WithMany(x => x.MenuItemIngredients)
               .HasForeignKey(x => x.IngredientId);


            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, ParentCategoryId = null, Name = "Recipes" },
            new Category { Id = 2, ParentCategoryId = null, Name = "Ingredients" },
            new Category { Id = 3, ParentCategoryId = null, Name = "MenuItem" },
            new Category { Id = 4, ParentCategoryId = 2, Name = "Dairy" },
            new Category { Id = 5, ParentCategoryId = 2, Name = "Sweetener" },
            new Category { Id = 6, ParentCategoryId = 2, Name = "Flour" },
            new Category { Id = 7, ParentCategoryId = 3, Name = "Pastry" },
            new Category { Id = 8, ParentCategoryId = 3, Name = "Beverage" },
            new Category { Id = 9, ParentCategoryId = 3, Name = "Sandwich" },
            new Category { Id = 10, ParentCategoryId = 3, Name = "Cake" },
            new Category { Id = 11, ParentCategoryId = 3, Name = "Cookie" },
            new Category { Id = 12, ParentCategoryId = 3, Name = "Brownie" },
            new Category { Id = 13, ParentCategoryId = 3, Name = "Pastry cream" },
            new Category { Id = 14, ParentCategoryId = 2, Name = "Fruit" }
            ); 

           modelBuilder.Entity<Ingredient>().HasData(
           new Ingredient { Id = 1, Name = "Butter",CategoryId = 4},
           new Ingredient { Id = 2, Name = "Milk", CategoryId = 4 },
           new Ingredient { Id = 3, Name = "Sugar",CategoryId = 5 },
           new Ingredient { Id = 4, Name = "Brown Sugar", CategoryId = 5 },
           new Ingredient { Id = 5, Name = "Flour",CategoryId = 6 },
           new Ingredient { Id = 6, Name = "StrawBerry", CategoryId = 6 });

            modelBuilder.Entity<Recipe>().HasData(
            new Recipe { Id = 1, Name = "Brownie", CategoryId = 12 },
            new Recipe { Id = 2, Name = "Sponge Cake", CategoryId = 10 },
            new Recipe{ Id = 3, Name = "Chocolate chip cookie", CategoryId = 11 },
            new Recipe { Id = 4, Name = "Butter Cream", CategoryId = 13 });

            modelBuilder.Entity<RecipeIngredient>().HasData(
            new RecipeIngredient { IngredientId = 1, RecipeId = 2, Unit = "20g" },
            new RecipeIngredient { IngredientId = 3, RecipeId = 3 ,Unit = "1cup"},
            new RecipeIngredient { IngredientId = 5, RecipeId = 4, Unit = "2cups" },
            new RecipeIngredient { IngredientId = 5, RecipeId = 3 ,Unit = "2cups"});

            modelBuilder.Entity<MenuItem>().HasData(
            new Ingredient { Id = 1, Name = "Strawberry Shortcake", CategoryId = 10 },
            new Ingredient { Id = 2, Name = "Chocolate chip cookie", CategoryId = 11 },
            new Ingredient { Id = 3, Name = "Croissant", CategoryId = 10 });
            
            modelBuilder.Entity<MenuItemRecipes>().HasData(
            new MenuItemRecipes { MenuItemId = 1, RecipeId = 2, },
            new MenuItemRecipes { MenuItemId = 1, RecipeId = 4  }
            );
            modelBuilder.Entity<MenuItemIngredient>().HasData(
            new MenuItemIngredient { MenuItemId = 1, IngredientId = 6, },
            new MenuItemIngredient { MenuItemId = 1, IngredientId = 4 }
            );

        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BakeryContext>
    {
        public BakeryContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath("/Users/Liangyew/Desktop/Bakery/BakeryMain")
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<BakeryContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new BakeryContext(builder.Options);
        }
    }
}
