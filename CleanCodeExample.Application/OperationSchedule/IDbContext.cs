using CleanCodeExample.Domain.Entities;

namespace CleanCodeExample.Application.OperationSchedule
{
    public interface IDbContext
    {
        void Add(TimeSeries timeSeries);

        void Save();
    }
}