using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class FeesDoctor
    {
        public int Id { get; set; }

        public string PatientId { get; set; } = string.Empty;

        public string DoctorId { get; set; } = string.Empty;

        public int BookingId { get; set; }    

        public long Duration { get; set; }

        public DateTime? FeesDate { get; set; }

        public double Price { get; set; }

        public virtual Patient? Patient { get; set; }

        public virtual Doctor? Doctor { get; set; }

        public virtual PatientBooking? PatientBooking { get; set; }


    }
}
