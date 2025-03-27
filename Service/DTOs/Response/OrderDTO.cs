using Persistence.Entities;
using Persistence.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public required string UserId { get; set; }

        public required string providerId { get; set; }

        public DateTime? DateOrder { get; set; }

        public StatusOrder StatusOrder { get; set; }

        public virtual PatientDTO? Patient { get; set; }

        public virtual MedicineProviderDTO? MedicineProvider { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
