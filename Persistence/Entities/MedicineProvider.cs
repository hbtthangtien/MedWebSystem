using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class MedicineProvider
    {
        public required string UserId { get; set; } 

        public string? Location { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Medicine> Medicines { get; set;} = new List<Medicine>()!;
    }
}
