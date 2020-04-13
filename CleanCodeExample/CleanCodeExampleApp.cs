using System;
using Microsoft.Extensions.Logging;

namespace CleanCodeExample.Infrastructure
{
    internal class CleanCodeExampleApp
    {
        private ILogger<CleanCodeExampleApp> _logger;

        public CleanCodeExampleApp(ILogger<CleanCodeExampleApp> logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.LogInformation("App started");

            Console.WriteLine("Hello World!");

            _logger.LogInformation("App ended");
        }
    }
}