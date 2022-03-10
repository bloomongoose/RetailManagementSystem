using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            //seeding some data 
            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, Name = "Beverage", Description = "Beverage" },
                    new Category { CategoryId = 2, Name = "Bakery", Description = "Baked Goods" },
                    new Category { CategoryId = 3, Name = "Meat", Description = "Meat" }

                );

            modelBuilder.Entity<Product>().HasData(
                    new Product { ProductId = 1, CategoryId = 1, Name = "La Croix", Quantity = 50, Price = 11.99 },
                    new Product { ProductId = 2, CategoryId = 1, Name = "Dr. Pepper", Quantity = 50, Price = 9.99 },
                    new Product { ProductId = 3, CategoryId = 2, Name = "Lemon Bars", Quantity = 100, Price = 14.99 },
                    new Product { ProductId = 4, CategoryId = 2, Name = "Croissants", Quantity = 100, Price = 8.99 },
                    new Product { ProductId = 5, CategoryId = 3, Name = "Chicken", Quantity = 60, Price = 15.99 },
                    new Product { ProductId = 6, CategoryId = 3, Name = "Turkey", Quantity = 40, Price = 18.99 }

                );
        }   
    }
}
