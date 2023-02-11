using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;

namespace Demo.Config;

internal sealed class Program
{
    static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false, true)
            .Build();

        var serviceCollection = new ServiceCollection()
            .AddTransient<ISettingsLogger, SettingsLogger>();
        serviceCollection.AddOptions<SampleSettings>()
            .Bind(configuration.GetSection(SampleSettings.SectionName))
            .ValidateDataAnnotations();
        var services = serviceCollection.BuildServiceProvider();

        services.GetRequiredService<ISettingsLogger>().LogSettings();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
