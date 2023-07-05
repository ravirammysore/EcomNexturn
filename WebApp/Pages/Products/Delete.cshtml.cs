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
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Pages;

[Authorize]
public class DeleteModel : PageModel
{
    [BindProperty]
    public Product Product { get; set; }

    public IActionResult OnGet(int? id)
    {
        if (id == null) return NotFound();

        ProductService productService = new ProductService();
        Product = productService.GetProduct(id.Value);

        return Page();
    }

    public IActionResult OnPost(int? id)
    {
        if (id == null) return NotFound();

        ProductService productService = new ProductService();
        productService.DeleteProduct(Product);

        return RedirectToPage("./Index");
    }
}
