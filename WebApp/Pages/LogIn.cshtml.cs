using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {
            // Optional: Perform any necessary initialization logic when the page is requested via HTTP GET.
        }

        public IActionResult OnPost()
        {
            // Validate the login credentials and perform authentication logic here.
            // Example validation logic:
            if (Email == "admin" && Password == "12345")
            {
                // Successful login
                return RedirectToPage("./Products/Index"); // Redirect to the Dashboard page
            }

            // Invalid credentials, show an error message
            ModelState.AddModelError(string.Empty, "Invalid username or password.");

            return Page();
        }
    }
}
