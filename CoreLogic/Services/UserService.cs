using CoreLogic.Data;
using CoreLogic.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services;

public class UserService
{
    MyContext ctx;
    public UserService()
    {
        ctx = new MyContext();
    }
    public List<User> GetAll()
    {
        return ctx.Users.ToList();
    }

    public void Register(User user)
    {
        ctx.Users.Add(user);
        ctx.SaveChanges();
    }

    public User Get(string userName)
    {
        return ctx.Users.SingleOrDefault(x => x.UserName == userName);
    }
   
}
