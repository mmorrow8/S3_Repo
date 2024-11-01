using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using S3_EF;
using System;

[assembly: FunctionsStartup(typeof(S3.Startup))]

namespace S3
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var configuration = builder.GetContext().Configuration;
            var services = builder.Services;

            var useInMemoryDatabase = configuration.GetValue<bool>("UseInMemoryDatabase");

            if (useInMemoryDatabase)
            {
                services.AddDbContext<S3DbContext>(options =>
                    options.UseInMemoryDatabase(Guid.NewGuid().ToString()));  // Unique database for each test;
            }
            else
            {
                // Add Application Insights telemetry
                services.AddApplicationInsightsTelemetryWorkerService();
                services.ConfigureFunctionsApplicationInsights();

                // Configure DbContext with SQL Server connection string
                services.AddDbContext<S3DbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("S3Database")));
            }
        }
    }
}
