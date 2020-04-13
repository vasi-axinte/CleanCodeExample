using CleanCodeExample.Domain.Interfaces;

namespace CleanCodeExample.Application.Interfaces
{
    public interface IDateTimeService
    {
        IDateTime Now { get; }
    }
}
