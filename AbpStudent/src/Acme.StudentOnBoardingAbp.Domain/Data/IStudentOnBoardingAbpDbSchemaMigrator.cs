using System.Threading.Tasks;

namespace Acme.StudentOnBoardingAbp.Data;

public interface IStudentOnBoardingAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
