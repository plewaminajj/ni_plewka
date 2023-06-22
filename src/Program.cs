using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using src;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Math app!");
        using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<IMath, MathService>();
    })
    .Build();

    }
}