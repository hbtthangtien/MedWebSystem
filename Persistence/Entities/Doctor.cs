using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Doctor
    {
        public required string UserId { get; set; }

        public string? Specialization {  get; set; }

        public string? LisenceNumber { get; set; }

        public string? Hospital {  get; set; }

        public int YearOfExperiences { get; set; }

        public virtual User? User { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

        public virtual ICollection<PatientBooking> PatientBookings { get; set; } = new List<PatientBooking>();

        public virtual ICollection<FeesDoctor> FeesDoctors { get; set; } = new List<FeesDoctor>();

        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        
        public virtual ICollection<ScheduleDoctor> ScheduleDoctors { get; set; }= new List<ScheduleDoctor>();

    }
}
