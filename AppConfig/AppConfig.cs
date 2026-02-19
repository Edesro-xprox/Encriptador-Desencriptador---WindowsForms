using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

public static class AppConfig
{
    public static IConfiguration Configuration { get; }

    static AppConfig()
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
    }
}