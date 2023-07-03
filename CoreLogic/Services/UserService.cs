using CoreLogic.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services;

public class UserService
{
    public List<User> GetAll()
    {
        var users = new List<User>()
        {
            new User() { Id = 1,Name = "Sam"},
            new User() { Id = 2,Name = "Ted" }
        };

        return users;   
    }
}
