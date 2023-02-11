using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Demo.Config;

internal sealed class Program
{
    static async Task Main(string[] args)
    {
        await Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(configurationBuilder =>
            {
                configurationBuilder.AddJsonFile("appsettings.json", false, true).Build();
            })
            .ConfigureLogging((context, logging) =>
            {
                logging.ClearProviders();
            })
            .ConfigureServices((context, serviceCollection) =>
            {
                serviceCollection.AddOptions<SampleSettings>()
                    .Bind(context.Configuration.GetSection(SampleSettings.SectionName))
                    .ValidateDataAnnotations()
                    .ValidateOnStart();
                serviceCollection.AddSingleton(services => services.GetRequiredService<IOptions<SampleSettings>>().Value);
                serviceCollection.AddTransient<ISettingsLogger, SettingsLogger>();
                serviceCollection.AddHostedService<ProgramService>();
            })
            .RunConsoleAsync();
    }
}

internal sealed class ProgramService : IHostedService
{
    private readonly IHostApplicationLifetime appLifetime;
    private readonly ISettingsLogger settingsLogger;

    public ProgramService(IHostApplicationLifetime appLifetime, ISettingsLogger settingsLogger)
    {
        this.appLifetime = appLifetime;
        this.settingsLogger = settingsLogger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        appLifetime.ApplicationStarted.Register(() =>
        {
            try
            {
                settingsLogger.LogSettings();
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            finally
            {
                appLifetime.StopApplication();
            }
        });

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
