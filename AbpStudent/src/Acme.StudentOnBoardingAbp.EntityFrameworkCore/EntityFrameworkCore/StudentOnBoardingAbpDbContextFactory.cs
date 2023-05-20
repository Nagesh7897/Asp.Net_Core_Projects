using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.StudentOnBoardingAbp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class StudentOnBoardingAbpDbContextFactory : IDesignTimeDbContextFactory<StudentOnBoardingAbpDbContext>
{
    public StudentOnBoardingAbpDbContext CreateDbContext(string[] args)
    {
        StudentOnBoardingAbpEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<StudentOnBoardingAbpDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new StudentOnBoardingAbpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.StudentOnBoardingAbp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
