using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Symptoms
    {
        public int Id { get; set; } 
        public string? Descriptions { get; set; }

        public ICollection<Disease> Diseases { get; set; } = new List<Disease>();
    }
}
