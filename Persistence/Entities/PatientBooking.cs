using Persistence.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class PatientBooking
    {
        public int Id { get; set; }

        public required string DoctorId { get; set; }

        public required string PatientId { get; set;}

        public int ScheduleDoctorId { get; set; }

        public StatusBooking StatusBooking { get; set; }

        public virtual Doctor? Doctor { get; set; }

        public virtual Patient? Patient { get; set; }

        public virtual ScheduleDoctor? Schedule { get; set;}



    }
}
