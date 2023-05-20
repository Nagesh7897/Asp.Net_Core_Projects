using Volo.Abp.Modularity;

namespace Acme.StudentOnBoardingAbp;

[DependsOn(
    typeof(StudentOnBoardingAbpApplicationModule),
    typeof(StudentOnBoardingAbpDomainTestModule)
    )]
public class StudentOnBoardingAbpApplicationTestModule : AbpModule
{

}
