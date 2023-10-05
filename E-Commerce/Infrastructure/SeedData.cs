using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category fruits = new Category { Name = "Fruits",Slug = "fruits" };
                Category shirts = new Category { Name = "Shirts",Slug = "shirts" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Apples",
                            Slug = "apples",
                            Description = "Tasty Apples",
                            Price = 1.50M,
                            Category = fruits
                        },
                        new Product
                        {
                            Name = "Lemons",
                            Slug = "lemons",
                            Description ="Sour Lemons",
                            Price = 2M,
                            Category = fruits
                        },
                        new Product
                        {
                            Name = "Watermelon",
                            Slug = "watermelon",
                            Description = "Juicy Watermelon",
                            Price = 0.50M,
                            Category = fruits
                        },
                        new Product
                        {
                            Name = "Grapefruit",
                            Slug = "grapefruit",
                            Description = "Tasty grapefruit",
                            Price = 2.50M,
                            Category = fruits
                        },
                        new Product
                        {
                            Name = "Blue shirt",
                            Slug = "blue-shirt",
                            Description = "blue shirt",
                            Price = 5.99M,
                            Category = shirts,
                            Image = ""
                        },
                        new Product
                        {
                            Name = "Black shirt",
                            Slug = "black-shirt",
                            Description = "Black shirt",
                            Price = 7.99M,
                            Category = shirts,
                            Image = ""
                        },
                        new Product
                        {
                            Name = "Red shirt",
                            Slug = "red-shirt",
                            Description = "Red shirt",
                            Price = 9.99M,
                            Category = shirts,
                            Image = ""
                        },
                        new Product
                        {
                            Name = "Gray shirt",
                            Slug = "gray-shirt",
                            Description = "Gray shirt",
                            Price = 11.99M,
                            Category = shirts,
                            Image = ""
                        }
                );

                context.SaveChanges();
            }
        }
    }
}
