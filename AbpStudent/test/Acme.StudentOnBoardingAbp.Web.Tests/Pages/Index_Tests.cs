using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.StudentOnBoardingAbp.Pages;

public class Index_Tests : StudentOnBoardingAbpWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
