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
        void getAllProduct()
        {
            var products = new List<Product>()
            {
                new Product(){ Id = 1, Category = "Mobile", Name = 'One Plus', Description = "6GB RAM, 64GB storage", Price = 20000, Quantity = 2},
                new Product(){ Id = 2, Category = "Laptop", Name = 'MSI', Description = "8GB RAM, 512GB storage (SSD)", Price = 20000, Quantity = 2}
            }
        }
    }
}
