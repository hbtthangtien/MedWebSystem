using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class SymptomDTO
    {
        public int Id { get; set; }
        public string? Descriptions { get; set; }
        public ICollection<DiseaseDTO> Diseases { get; set; } = new List<DiseaseDTO>();
    }
}
