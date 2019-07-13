using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerTimeGraph.Core.Model
{
    public class TimeWorked
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int HoursWorked { get; set; }
        public int StaffId { get; set; }
    }
}
