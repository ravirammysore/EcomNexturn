using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Models;

    public class Category
    {
        IEnumerable<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int Id{ get; set; }
        public string Name { get; set; }

    }
