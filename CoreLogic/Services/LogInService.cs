using CoreLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services
{
    public class LogInService
    {
        public List<LogIn> GetLogIn()
        {
            var logInList = new List<LogIn>()
            {
                new LogIn() { Id = 1 , Password = "doremon123"},
                new LogIn() { Id = 2 ,Password = "sinchan345"}
            };
            return logInList;
        }

    }
}
