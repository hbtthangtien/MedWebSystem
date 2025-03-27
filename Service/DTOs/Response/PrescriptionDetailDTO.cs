using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class PrescriptionDetailDTO
    {
        public int Id { get; set; }

        public int PrescriptionId { get; set; }

        public int MedicineId { get; set; }

        public int Quantity { get; set; }

        public string? Dossage { get; set; }

        public virtual PrescriptionDTO? Prescription { get; set; }

        public virtual MedicineDTO? Medicine { get; set; }
    }
}
