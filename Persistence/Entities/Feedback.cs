using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Feedback
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Description { get; set; } = string.Empty;

        public virtual Patient? Patient { get; set; }
    }
}
