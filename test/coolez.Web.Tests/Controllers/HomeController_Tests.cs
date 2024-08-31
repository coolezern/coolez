using System.Threading.Tasks;
using coolez.Web.Controllers;
using Shouldly;
using Xunit;

namespace coolez.Web.Tests.Controllers
{
    public class HomeController_Tests: coolezWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
