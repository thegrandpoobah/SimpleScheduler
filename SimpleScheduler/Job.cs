using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleScheduler
{
    internal class Job
    {
        public Guid Id { get; set; }
        public Action Action { get; set; }
        public double MillisecondsToTrigger { get; set; }
        public bool Enabled { get; set; }
    }
}
