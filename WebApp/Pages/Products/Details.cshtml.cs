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

public class DetailsModel : PageModel
{
    public Product Product { get; set; } = default!;
  
    public IActionResult OnGet(int? id)
    {
        if (id == null) return NotFound();

        ProductService productService = new ProductService();
        Product = productService.GetProduct(id.Value);
        
        if (Product == null) return NotFound();
        
        return Page();
    }
}
