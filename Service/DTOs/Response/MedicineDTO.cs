using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class MedicineDTO
    {
        public int Id { get; set; }

        public string ProviderId { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string? Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public virtual MedicineProviderDTO? MedicineProvider { get; set; }

        public virtual ICollection<DiseaseDTO> Diseases { get; set; } = new List<DiseaseDTO>();
    }
}
