using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class PrescriptionDTO
    {
        public int Id { get; set; }

        public required string PatientId { get; set; }

        public required string DoctorId { get; set; }

        public DateTime DateIssue { get; set; }

        public string? Description { get; set; }

        public virtual PatientDTO? Patient { get; set; }

        public virtual DoctorDTO? Doctor { get; set; }

        public virtual List<PrescriptionDetailDTO> Details { get; set; } = new List<PrescriptionDetailDTO>();
    }
}
