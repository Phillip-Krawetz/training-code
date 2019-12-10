using Devops.Client.Controllers;
using Xunit;
using Microsoft.Extensions.Logging;

namespace Devops.Testing
{
  public class ClientTest
  {
    private readonly ILogger<HomeController> logger = LoggerFactory.Create(o => o.SetMinimumLevel(LogLevel.Debug)).CreateLogger<HomeController>();
    [Fact]
    public void Test_IndexPage()
    {
      var home = new HomeController(logger);
      var index = home.Index();

      Assert.NotNull(index);
    }

    [Fact]
    public void Test_PrivacyPage()
    {
      var home = new HomeController(logger);
      var privacy = home.Privacy();

      Assert.NotNull(privacy);
    }
  }
}