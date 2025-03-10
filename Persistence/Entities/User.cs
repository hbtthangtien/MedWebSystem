using Microsoft.AspNetCore.Identity;
using Persistence.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class User : IdentityUser
    {
        public UserGender Gender { get; set; }

        public string? Fullname { get; set; }

        public string? Address { get; set; }

        public virtual Doctor? Doctor { get; set; }

        public virtual Patient? Patient { get; set; }

        public virtual MedicineProvider? MedicineProvider { get; set; }

    }
}
