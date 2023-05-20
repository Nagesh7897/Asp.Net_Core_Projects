using System;
using System.Collections.Generic;
using System.Text;
using Acme.StudentOnBoardingAbp.Localization;
using Volo.Abp.Application.Services;

namespace Acme.StudentOnBoardingAbp;

/* Inherit your application services from this class.
 */
public abstract class StudentOnBoardingAbpAppService : ApplicationService
{
    protected StudentOnBoardingAbpAppService()
    {
        LocalizationResource = typeof(StudentOnBoardingAbpResource);
    }
}
