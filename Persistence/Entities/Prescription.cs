using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Prescription
    {
        public int Id { get; set; } 

        public required string PatientId { get; set; }

        public required string DoctorId { get; set; }

        public DateTime DateIssue {  get; set; }

        public string? Description { get; set; }

        public virtual Patient? Patient { get; set; }

        public virtual Doctor? Doctor { get; set; }

        public virtual List<PrescriptionDetail> Details { get; set; } = new List<PrescriptionDetail>();

    }
}
