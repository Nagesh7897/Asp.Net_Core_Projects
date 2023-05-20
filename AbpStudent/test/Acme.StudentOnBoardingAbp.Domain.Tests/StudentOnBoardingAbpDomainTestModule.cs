using Acme.StudentOnBoardingAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.StudentOnBoardingAbp;

[DependsOn(
    typeof(StudentOnBoardingAbpEntityFrameworkCoreTestModule)
    )]
public class StudentOnBoardingAbpDomainTestModule : AbpModule
{

}
