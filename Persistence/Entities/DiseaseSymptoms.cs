using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class DiseaseSymptoms
    {
        public int Id { get; set; }

        public int DiseaseId { get; set; }

        public int SymptomsId { get; set; }

        public virtual Disease? Disease { get; set; }

        public virtual Symptoms? Symptoms { get; set; }
    }
}
