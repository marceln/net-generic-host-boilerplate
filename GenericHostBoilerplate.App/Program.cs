// See https://aka.ms/new-console-template for more information
using GenericHostBoilerplate.App.HostedServices;
using GenericHostBoilerplate.App.Services;
using GenericHostBoilerplate.App.Services.Impl;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

CreateHostBuilder(args).Build().Run();

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
            services.AddLogging();
            services.AddTransient<IExampleService, ExampleService>();
            services.AddHostedService<HostedService>();
        })
        .ConfigureAppConfiguration(options =>
        {
            options.AddEnvironmentVariables();
            options.AddJsonFile("appsettings.json", optional: false);
            options.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT")}.json", optional: false);
        });