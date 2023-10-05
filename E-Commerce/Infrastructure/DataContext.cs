using Microsoft.EntityFrameworkCore;
using E_Commerce.Models;
using System.Reflection.Metadata;

namespace E_Commerce.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { Id =1, Name = "Fruit", Slug = "fruit" }, 
                new Category { Id = 2, Name = "Fruit2", Slug = "fruit2" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "Fruit", Slug = "fruit", Description = "type of fruit"}, 
                new Product { Id = 5, Name ="Shirt", Slug = "shirt", Description = "color of the shirt" });
            

        }
    }
}
