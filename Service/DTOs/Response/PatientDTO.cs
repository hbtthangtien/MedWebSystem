using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class PatientDTO
    {
        public required string UserId { get; set; }

        public virtual ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>();

        public virtual ICollection<PaymentDTO> Payments { get; set; } = new List<PaymentDTO>();

        public virtual ICollection<PrescriptionDTO> Prescriptions { get; set; } = new List<PrescriptionDTO>();

        public virtual ICollection<PatientBookingDTO> PatientBookings { get; set; } = new List<PatientBookingDTO>();

        public virtual ICollection<FeesDoctorDTO> FeesDoctors { get; set; } = new List<FeesDoctorDTO>();

        public virtual UserDTO? User { get; set; }
    }
}
