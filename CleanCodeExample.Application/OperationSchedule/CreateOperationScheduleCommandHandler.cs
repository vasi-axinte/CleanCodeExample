using CleanCodeExample.Domain.Entities;

namespace CleanCodeExample.Application.OperationSchedule
{
    public class CreateOperationScheduleCommandHandler
    {
        IDbContext _dbContext;

        public CreateOperationScheduleCommandHandler(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle(CreateOperationScheduleCommand command)
        {
            // some validation goes here

            var timeSeries = new TimeSeries
            {
                Id = "test",
                Value = command.Value
            };

            _dbContext.Add(timeSeries);
            _dbContext.Save();
        }
    }
}
