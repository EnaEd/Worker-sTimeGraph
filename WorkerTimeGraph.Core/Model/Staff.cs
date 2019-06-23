using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerTimeGraph.Core.Model
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int HoursWorked { get; set; }
        public string DaysWorked { get; set; }
    }
}
