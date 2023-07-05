using CoreLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreLogic.Data;

public class MyContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }

    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var server = "(localdb)";
        var instance = "MyInstance";
        var database = "ECommDB";
        var authentication = "Integrated Security = true";
        //var authentication = "user = sa; password = abc1234";

        var conString = $"Data Source={server}\\{instance}; Initial Catalog={database};{authentication}";

        options.UseSqlServer(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
         new Category
         {
             Id = 1,
             Name = "Electronics"
         },
         new Category
         {
             Id = 2,
             Name = "Clothing"
         }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "iPhone 12",
                Description = "Apple iPhone 12 - 128GB",
                Price = 1000,
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Name = "Samsung Galaxy S20",
                Description = "Samsung Galaxy S20 - 128GB",
                Price = 900,
                CategoryId = 1
            },
            new Product
            {
                Id = 3,
                Name = "T-shirt",
                Description = "Plain White T-shirt",
                Price = 20,
                CategoryId = 2
            },
            new Product
            {
                Id = 4,
                Name = "Jeans",
                Description = "Blue Denim Jeans",
                Price = 50,
                CategoryId = 2
            }
        );

        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Name = "Ravi",
                UserName = "ravi",
                Password = "123"
            },
            new User
            {
                Id = 2,
                Name = "John",
                UserName = "jhon",
                Password = "123"
            },
            new User
            {
                Id = 3,
                Name = "Jane",
                UserName = "jane",
                Password = "123"
            }          
        );

    }
}