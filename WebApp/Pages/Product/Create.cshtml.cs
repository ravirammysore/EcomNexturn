using CoreLogic.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly MyContext _context;

        public CreateModel(MyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Product);
            _context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
