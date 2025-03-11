using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int MedicineId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public virtual Order? Order { get; set; }

        public virtual Medicine? Medicine { get; set; }
    }
}
