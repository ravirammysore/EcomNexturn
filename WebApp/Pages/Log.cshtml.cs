using CoreLogic.Models;
using CoreLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class LogModel : PageModel
    {

        public List<Log> Logs { get; set; }

        public void OnGet()
        {
            LogService service = new LogService();
            Logs = service.GetAll();
        }
    }
}



    