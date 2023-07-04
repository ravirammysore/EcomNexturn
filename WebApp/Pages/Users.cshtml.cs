using CoreLogic.Models;
using CoreLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class UsersModel : PageModel
    {

        public List<User> Users { get; set; }
        
        public void OnGet()
        {
            UserService service = new UserService();
            Users = service.GetAll();
        }
    }
}
