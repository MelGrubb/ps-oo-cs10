using Microsoft.Extensions.Options;

namespace Demo.Config;

internal interface ISettingsLogger
{
    void LogSettings();
}

internal class SettingsLogger : ISettingsLogger
{
    private readonly SampleSettings _sampleSettings;

    public SettingsLogger(SampleSettings sampleSettings)
    {
        _sampleSettings = sampleSettings;
    }

    public void LogSettings()
    {
        Console.WriteLine($"StringSetting = '{_sampleSettings.StringSetting}'");
        Console.WriteLine($"IntSetting = {_sampleSettings.IntSetting}");
        Console.WriteLine($"BoolSetting = {_sampleSettings.BoolSetting}");
        Console.WriteLine($"DateSetting = {_sampleSettings.DateSetting}");
    }
}
