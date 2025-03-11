using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Enum
{
    public enum StatusOrder
    {
        Canceled = -2,
        Declined = -1,
        Processing = 0,
        Approved = 1,
        Successfully  = 2,
    }
}
