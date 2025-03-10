using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Patient
    {
        public required string UserId { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

        public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

        public virtual ICollection<PatientBooking> PatientBookings { get; set; } = new List<PatientBooking>();

        public virtual ICollection<FeesDoctor> FeesDoctors { get; set; } = new List<FeesDoctor>();

        public virtual User? User { get; set; }
    }
}
