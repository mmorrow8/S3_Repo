using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using S3_EF;
using System;

var host = new HostBuilder()
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
              .AddEnvironmentVariables();
    })
    .ConfigureFunctionsWebApplication()
    .ConfigureServices((context, services) =>
    {
        var configuration = context.Configuration;
        var useInMemoryDatabase = configuration.GetValue<bool>("UseInMemoryDatabase");

        if (useInMemoryDatabase)
        {
            services.AddDbContext<S3DbContext>(options =>
                options.UseInMemoryDatabase(Guid.NewGuid().ToString())); // Unique database for each test
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
    })
    .Build();

host.Run();