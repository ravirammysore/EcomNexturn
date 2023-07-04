using CoreLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services
{
    public class LogService
    {
        public List<Log> GetAll()
        {
            var logList = new List<Log>()
            {
                new Log() { Id = 1 , Description = "doremon123"},
                new Log() { Id = 2 , Description = "sinchan345"}
            };
            return logList;
        }

    }
}
