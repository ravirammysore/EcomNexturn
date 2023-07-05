using CoreLogic.Data;
using CoreLogic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services;

public class ProductService
{
    MyContext ctx;
    public ProductService() 
    {
        ctx = new MyContext();
    }
    public void AddProduct(Product product)
    {
        ctx.Products.Add(product);
        ctx.SaveChanges();
    }

    public void DeleteProduct(Product product)
    {
        ctx.Products.Remove(product);
        ctx.SaveChanges();
    }
    public Product GetProduct(int id)
    {
        return ctx.Products.Include(c => c.Category).Single(p => p.Id == id);
    }

    public List<Product> getAllProducts()
    {
        var products = ctx.Products.Include(c => c.Category).ToList();
        return products;
    }

    public void UpdateProduct(Product product)
    {
        if(product != null && ctx.Products.Any(p => p.Id == product.Id) )
        {
            ctx.Attach(product).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }

    public List<Category> getCategories()
    {
        return ctx.Categories.ToList();
    }
}
