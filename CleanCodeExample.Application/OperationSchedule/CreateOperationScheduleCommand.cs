using System;
using System.Collections.Generic;
using System.Text;
using CleanCodeExample.Application.Models;

namespace CleanCodeExample.Application.OperationSchedule
{
    public class CreateOperationScheduleCommand
    {
        public string Id { get; set; }
        public decimal Value { get; set; }
    }
}
