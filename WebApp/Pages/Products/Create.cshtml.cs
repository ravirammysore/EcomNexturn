﻿using System;
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
using Microsoft.EntityFrameworkCore;

namespace WebApp.Pages;
[Authorize]
public class CreateModel : PageModel
{
    private ProductService productService;

    [BindProperty]
    public Product Product { get; set; } = default!;

    public List<SelectListItem> CategoryOptions { get; set; }

    public CreateModel()
    {
        productService = new ProductService();
    }

    public IActionResult OnGet()
    {
        var categories = productService.getCategories();
        PopulateCategoriesDropDown();
        return Page();
    }
  
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid || Product == null)
        {
            PopulateCategoriesDropDown();
            return Page();
        }

        productService.AddProduct(Product);
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