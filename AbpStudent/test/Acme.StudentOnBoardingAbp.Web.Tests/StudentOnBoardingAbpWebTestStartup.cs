using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Acme.StudentOnBoardingAbp;

public class StudentOnBoardingAbpWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<StudentOnBoardingAbpWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
