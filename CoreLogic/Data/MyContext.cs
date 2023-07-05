using CoreLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreLogic.Data;

public class MyContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public object Login { get; internal set; }

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
}