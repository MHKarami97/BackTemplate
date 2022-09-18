using System.Threading.Tasks;
using BackTemplate.Models.TokenAuth;
using BackTemplate.Web.Controllers;
using Shouldly;
using Xunit;

namespace BackTemplate.Web.Tests.Controllers
{
    public class HomeController_Tests: BackTemplateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}