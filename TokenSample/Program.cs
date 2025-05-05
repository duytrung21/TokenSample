using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using TokenSample;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    private static object CreateHostBuilder(string[] args)
    {
        throw new NotImplementedException();
    }
}