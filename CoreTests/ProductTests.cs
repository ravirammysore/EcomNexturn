using CoreLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests
{
    public class ProductTests
    {
        ProductService productService;
        [SetUp]

        public void Setup()
        {
            productService = new ProductService();
        }

        [Test]
        public void GetAllProductWorkAsExpected()
        {
            // call the service
            var res = productService.getAllProduct();
            var count = res.Count();

            // make sure that the count is not zero
            Assert.IsTrue(count >0);
        }
    }
}
