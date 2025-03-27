using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class ShiftDTO
    {
        public int ShiftId { get; set; }

        public string? ScheduleTime { get; set; }
    }
}
