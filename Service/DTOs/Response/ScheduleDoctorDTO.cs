using Persistence.Entities;
using Persistence.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class ScheduleDoctorDTO
    {
        public int Id { get; set; }

        public int ScheduleDateId { get; set; }

        public int ShiftId { get; set; }

        public string? DoctorId { get; set; }

        public ScheduleStatus ScheduleStatus { get; set; }

        public virtual ScheduleDateDTO? ScheduleDate { get; set; }

        public virtual ShiftDTO? Shift { get; set; }

        public virtual DoctorDTO? Doctor { get; set; }
    }
}
