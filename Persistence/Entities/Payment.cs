using Persistence.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Payment
    {
        public int Id { get; set; } 

        public required string UserId { get; set; }

        public int OrderId { get; set; }

        public int FeesDoctorId { get; set; }

        public double TotalPrice { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public DateTime PaymentDate { get; set; }

        public StatusPayment StatusPayment { get; set; }

        public string? PaymentCode { get; set; }

        public string? PaymentDescription { get; set; }

        public virtual Patient? Patient { get; set; }

        public virtual Order? Order { get; set; }

        public virtual FeesDoctor? FeesDoctor { get; set; }

    }
}
