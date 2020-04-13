using System;
using System.Collections.Generic;
using System.Text;
using CleanCodeExample.Application.Models;
using CleanCodeExample.Application.OperationSchedule;

namespace CleanCodeExample.Infrastructure.DbAccess
{
    public class DbContext: IDbContext
    {
        private List<TimeSeriesDto> timeSeries;

        public void Add(TimeSeriesDto timeSeriesDto)
        {
            timeSeries.Add(timeSeriesDto);
        }

        public void Get()
    }
}
