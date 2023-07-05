﻿using System;
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
    private ProductService productService;

    [BindProperty]
    public Product Product { get; set; } = default!;

    public List<SelectListItem> CategoryOptions { get; set; }
    public EditModel()
    {
        productService = new ProductService();
    }    
    public IActionResult OnGetAsync(int? id)
    {
        if (id == null) return NotFound();
        
        Product = productService.GetProduct(id.Value);
        if (Product == null) return NotFound();
        
        PopulateCategoriesDropDown();

        return Page();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            PopulateCategoriesDropDown();
            return Page();
        }
        
        productService.UpdateProduct(Product);

        return RedirectToPage("./Index");
    }
    private void PopulateCategoriesDropDown()
    {
        var categories = productService.getCategories();

        CategoryOptions = categories.Select(category =>
                                  new SelectListItem
                                  {
                                      Value = category.Id.ToString(),
                                      Text = category.Name
                                  }).ToList();
    }
}
