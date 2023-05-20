using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentOnBoardingAbp.Web;

[Dependency(ReplaceServices = true)]
public class StudentOnBoardingAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentOnBoardingAbp";
}
