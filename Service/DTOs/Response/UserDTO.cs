using Persistence.Entities;
using Persistence.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class UserDTO
    {
        public UserGender Gender { get; set; }

        public string? Fullname { get; set; }

        public string? Address { get; set; }

        public virtual DoctorDTO? Doctor { get; set; }

        public virtual PatientDTO? Patient { get; set; }

        public virtual MedicineProviderDTO? MedicineProvider { get; set; }
    }
}
