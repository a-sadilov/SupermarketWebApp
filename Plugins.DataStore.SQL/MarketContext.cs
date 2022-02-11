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
                new Category { CategoryId = 1, Name = "Drinks", Description = "Beverage Description" },
                new Category { CategoryId = 2, Name = "Bekery", Description = "Bekery Description" },
                new Category { CategoryId = 3, Name = "Cheese", Description = "Cheese Description" },
                new Category { CategoryId = 4, Name = "Meat", Description = "Meat Description" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, Name = "Ice Tee", Quantity = 100, Price = 79.99 },
                new Product { ProductId = 2, CategoryId = 1, Name = "Fanta", Quantity = 100, Price = 89.99 },
                new Product { ProductId = 3, CategoryId = 2, Name = "Cheese Cake", Quantity = 20, Price = 119.99 },
                new Product { ProductId = 4, CategoryId = 2, Name = "Apple-Sharlotte", Quantity = 20, Price = 99.99 },
                new Product { ProductId = 5, CategoryId = 3, Name = "Parmesan", Quantity = 30, Price = 369.99 },
                new Product { ProductId = 6, CategoryId = 3, Name = "Lambert", Quantity = 50, Price = 259.99 }
                );
           
        }
    }
}
