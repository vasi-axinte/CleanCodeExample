using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CleanCodeExample.Infrastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);
            
            var serviceProvider =  serviceCollection.BuildServiceProvider();

            var app = serviceProvider.GetService<CleanCodeExampleApp>();
            
            app.Run();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddLogging(builder => builder.ClearProviders().AddConsole())
                .AddTransient<CleanCodeExampleApp>();
        }
    }
}
