using Acme.StudentOnBoardingAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.StudentOnBoardingAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentOnBoardingAbpEntityFrameworkCoreModule),
    typeof(StudentOnBoardingAbpApplicationContractsModule)
    )]
public class StudentOnBoardingAbpDbMigratorModule : AbpModule
{

}
