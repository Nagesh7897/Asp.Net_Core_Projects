using Acme.StudentOnBoardingAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.StudentOnBoardingAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentOnBoardingAbpController : AbpControllerBase
{
    protected StudentOnBoardingAbpController()
    {
        LocalizationResource = typeof(StudentOnBoardingAbpResource);
    }
}
