using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class DiseaseDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Treatements { get; set; }

        public string? ImageUrl { get; set; }

        public virtual ICollection<SymptomDTO> Symptoms { get; set; } = new List<SymptomDTO>();

        public virtual ICollection<MedicineDTO> Medicines { get; set; } = new List<MedicineDTO>();
    }
}
