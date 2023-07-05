using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreLogic.Data;
using CoreLogic.Models;
using CoreLogic.Services;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Pages;

[Authorize]
public class EditModel : PageModel
{
    [BindProperty]
    public Product Product { get; set; } = default!;

    public IActionResult OnGetAsync(int? id)
    {
        if (id == null) return NotFound();

        ProductService productService = new ProductService();
        Product = productService.GetProduct(id.Value);
        if (Product == null) return NotFound();
    
        return Page();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        ProductService productService = new ProductService();
        productService.UpdateProduct(Product);

        return RedirectToPage("./Index");
    }   
}
