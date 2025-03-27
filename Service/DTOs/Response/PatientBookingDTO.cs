using Persistence.Entities;
using Persistence.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class PatientBookingDTO
    {
        public int Id { get; set; }

        public required string DoctorId { get; set; }

        public required string PatientId { get; set; }

        public int ScheduleDoctorId { get; set; }

        public StatusBooking StatusBooking { get; set; }

        public virtual DoctorDTO? Doctor { get; set; }

        public virtual PatientDTO? Patient { get; set; }

        public virtual ScheduleDoctorDTO? Schedule { get; set; }
    }
}
