using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Medicine
    {
        public int Id { get; set; } 

        public string ProviderId { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string? Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public virtual MedicineProvider? MedicineProvider { get; set; }

        public virtual ICollection<Disease> Diseases { get; set; } = new List<Disease>();
    }
}
