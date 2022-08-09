using System;
using Xunit;
using Jenkins_CI_Demo.Controllers;
using System.Collections.Generic;
using System.Web.Http;

namespace Jenkins_CI_Demo_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var valueController = new ValuesController();
            var response = valueController.Get(1);
            Assert.IsType<string>(response);
        }
    }
}
