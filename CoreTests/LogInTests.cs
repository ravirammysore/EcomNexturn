using CoreLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests
{
    public class LogInTests
    {
        LogInService loginService;
        [SetUp]
        public void Setup()
        {
            loginService = new LogInService();
        }

        [Test]
        public void GetAllLogInsWorkAsExpected()
        {
            //call the service
            var res = loginService.GetLogIn();
            var count = res.Count();

            //make sure that the count is not zero
            Assert.IsTrue(count > 0);
        }
    }
}
