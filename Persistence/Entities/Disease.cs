﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class Disease
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Treatements { get; set; }

        public string? ImageUrl { get; set; }

        public virtual ICollection<Symptoms> Symptoms { get; set;} = new List<Symptoms>();

        public virtual ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();

    }
}
