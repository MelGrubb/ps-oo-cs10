using Microsoft.Extensions.Configuration;

namespace Demo.Config;

internal sealed class Program
{
    static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false, true)
            .Build();

        Console.WriteLine($"StringSetting = '{configuration.GetValue<string>("SampleSettings:StringSetting")}'");
        Console.WriteLine($"IntSetting = {configuration.GetValue<int>("SampleSettings:IntSetting")}");
        Console.WriteLine($"BoolSetting = {configuration.GetValue<bool>("SampleSettings:BoolSetting")}");
        Console.WriteLine($"DateSetting = {configuration.GetValue<DateTime>("SampleSettings:DateSetting")}");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}