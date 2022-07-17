using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPlanner
{
    public class Entities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }
        public int? NotifyBeforeInMinutes { get; set; }

        public Entities()
        {

        }
    }

    public class DateTimeDifference
    {
        public int Id { get; set; }
        public double? Value { get; set; }
        public int? Minutes { get; set; }
    }
}