using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreLogic.Data;
using CoreLogic.Models;
using CoreLogic.Services;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Pages;
[Authorize]
public class CreateModel : PageModel
{
    [BindProperty]
    public Product Product { get; set; } = default!;

    public IActionResult OnGet()
    {
        return Page();
    }

    public ActionResult OnPost()
    {
        if (!ModelState.IsValid || Product == null)
        {
            return Page();
        }

        ProductService productService = new ProductService();
        productService.AddProduct(Product);

        return RedirectToPage("./Index");
    }
}
