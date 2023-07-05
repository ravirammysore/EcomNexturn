using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreLogic.Data;
using CoreLogic.Models;
using CoreLogic.Services;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    public List<Product> Products { get; set; }
    
    public void OnGetAsync()
    {
        ProductService productService = new ProductService();
        Products = productService.getAllProduct();           
    }
}
