using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class ScheduleDate
    {
        public int Id { get; set; }

        public DateOnly Date {  get; set; }
    }
}
