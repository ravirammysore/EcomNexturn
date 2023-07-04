using CoreLogic.Data;
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
            MyContext ctx = new MyContext();

            var products = ctx.Products.ToList();
            return products;
        }
    }
}
