using System;
using CleanCodeExample.Application.OperationSchedule;
using CleanCodeExample.Infrastructure.DbAccess;
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

            var command = new CreateOperationScheduleCommand {Id = "", Value = 5};
            var dbContext = new DbContext();
            var commandHandler = new CreateOperationScheduleCommandHandler(dbContext);
            commandHandler.Handle(command);
            
            Console.WriteLine("Hello World!");

            _logger.LogInformation("App ended");
        }
    }
}