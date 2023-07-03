using CoreLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services
{
    public class ProductService
    {
        public List<Product> getAllProduct()
        {
            var products = new List<Product>()
            {
                new Product()
                { 
                    Id = 1, 
                    Name = "One Plus", 
                    Description = "6GB RAM, 64GB storage", 
                    Price = 20000,
                },
                new Product()
                { 
                    Id = 2, 
                    Name = "MSI", 
                    Description = "8GB RAM, 512GB storage (SSD)", 
                    Price = 20000
                }
            };
            return products;
        }
    }
}
