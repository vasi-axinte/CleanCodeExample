using System;
using System.Collections.Generic;
using System.Text;
using CleanCodeExample.Application.OperationSchedule;
using CleanCodeExample.Domain.Entities;

namespace CleanCodeExample.Infrastructure.DbAccess
{
    public class DbContext: IDbContext
    {
        private readonly List<TimeSeries> _timeSeries;

        public DbContext()
        {
            _timeSeries = new List<TimeSeries>();
        }

        public void Add(TimeSeries timeSeries)
        {
            _timeSeries.Add(timeSeries);
        }

        public void Save()
        {
            
        }
    }
}
