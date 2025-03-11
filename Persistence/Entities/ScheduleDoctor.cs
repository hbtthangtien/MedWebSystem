using Persistence.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class ScheduleDoctor
    {
        public int Id { get; set; }

        public int ScheduleDateId { get; set; }

        public int ShiftId { get; set; }

        public string? DoctorId { get; set; }

        public ScheduleStatus ScheduleStatus { get; set; }

        public virtual ScheduleDate? ScheduleDate { get; set; }

        public virtual Shift? Shift { get; set; }

        public virtual Doctor? Doctor { get; set; }
    }
}
