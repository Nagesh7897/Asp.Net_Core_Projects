using Acme.StudentOnBoardingAbp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.StudentOnBoardingAbp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StudentOnBoardingAbpPageModel : AbpPageModel
{
    protected StudentOnBoardingAbpPageModel()
    {
        LocalizationResourceType = typeof(StudentOnBoardingAbpResource);
    }
}
