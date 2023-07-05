using CoreLogic.Data;
using CoreLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services
{
    public class LoginService
    {
        MyContext ctx;
        public LoginService()
        {
            ctx = new MyContext();
        }
        public void Login(Login Login)
        {
            throw new NotImplementedException();
        }
    }
}
