using CoreLogic.Services;

namespace CoreTests
{
    public class UserTests
    {
        UserService userService;
        [SetUp]
        public void Setup()
        {
            userService = new UserService();
        }

        [Test]
        public void GetAllUsersWorkAsExpected()
        {
            //call the service
            var res = userService.GetAll();
            var count = res.Count();

            //make sure that the count is not zero
            Assert.IsTrue(count>0);
        }
    }
}