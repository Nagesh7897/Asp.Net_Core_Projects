using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentOnBoardingAbp.Data;

/* This is used if database provider does't define
 * IStudentOnBoardingAbpDbSchemaMigrator implementation.
 */
public class NullStudentOnBoardingAbpDbSchemaMigrator : IStudentOnBoardingAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
