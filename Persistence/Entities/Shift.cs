﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Shift
    {
        public int ShiftId { get; set; }

        public string? ScheduleTime { get; set; }
    }
}
