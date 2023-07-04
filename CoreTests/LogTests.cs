using CoreLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests
{
    public class LogTests
    {
        LogService logService;
        [SetUp]
        public void Setup()
        {
            logService = new LogService();
        }

        [Test]
        public void GetAllLogWorkAsExpected()
        {
            //call the service
            var res = logService.GetAll();
            var count = res.Count();

            //make sure that the count is not zero
            Assert.IsTrue(count > 0);
        }
    }
}
