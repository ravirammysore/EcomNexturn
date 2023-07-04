using CoreLogic.Models;
using CoreLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class IndexModel : PageModel
{

    ProductService service;
    public List<Product> Products { get; set; }
    public void OnGet()
    {
        service = new ProductService();
        Products = service.getAllProduct();
    }
}