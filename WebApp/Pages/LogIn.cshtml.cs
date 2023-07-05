using CoreLogic.Models;
using CoreLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public Login Login { get; set; } = default!;
       
        public void OnGet()
        {
            //New Changes
            // Optional: Perform any necessary initialization logic when the page is requested via HTTP GET.
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid || Login == null )
            {
                return Page();
            }

            LoginService loginService = new LoginService();
            loginService.Login(Login);

            return RedirectToPage("./Products/Index");
        }
    }

}
