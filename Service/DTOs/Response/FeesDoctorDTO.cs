using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class FeesDoctorDTO
    {
        public int Id { get; set; }

        public string PatientId { get; set; } = string.Empty;

        public string DoctorId { get; set; } = string.Empty;

        public int BookingId { get; set; }

        public long Duration { get; set; }

        public DateTime? FeesDate { get; set; }

        public double Price { get; set; }

        public virtual PatientDTO? Patient { get; set; }

        public virtual DoctorDTO? Doctor { get; set; }

        public virtual PatientBookingDTO? PatientBooking { get; set; }
    }
}
