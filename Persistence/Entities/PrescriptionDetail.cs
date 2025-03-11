using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class PrescriptionDetail
    {
        public int Id { get; set; }

        public int PrescriptionId { get; set; }

        public int MedicineId { get; set; }

        public int Quantity { get; set; }

        public string? Dossage { get; set; }

        public virtual Prescription? Prescription { get; set; }

        public virtual Medicine? Medicine { get; set; }
    }
}
