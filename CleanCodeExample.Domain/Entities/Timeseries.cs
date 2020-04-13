using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeExample.Domain.Entities
{
    public class TimeSeries
    {
        public string Id { get; set; }
        public decimal Value { get; set; }
    }

    //public class TimeValue
    //{
    //    public DateTime Time { get; set; }
    //    public decimal Value { get; set; }
    //}
}
