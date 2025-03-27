using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class MedicineProviderDTO
    {
        public required string UserId { get; set; }

        public string? Location { get; set; }

        public virtual UserDTO? User { get; set; }
        public virtual ICollection<MedicineDTO> Medicines { get; set; } = new List<MedicineDTO>()!;
    }
}
