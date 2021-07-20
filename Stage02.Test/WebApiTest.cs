using Stage02.WebApi.Controllers;
using System;
using Xunit;

namespace Stage02.Test
{
    public class WebApiTest
    {
        [Fact]
        public void WeatherForecastTest()
        {
            var response = new WeatherForecastController().Get();
            foreach (var item in response)
            {
                Assert.NotNull(item); 
            }
        }

        [Fact]
        public void PersonTest()
        {
            var response = new PersonController().Index();
            Assert.NotNull(response);

        }
    }
}
