using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.StudentOnBoardingAbp.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentOnBoardingAbp.EntityFrameworkCore;

public class EntityFrameworkCoreStudentOnBoardingAbpDbSchemaMigrator
    : IStudentOnBoardingAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudentOnBoardingAbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StudentOnBoardingAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudentOnBoardingAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
