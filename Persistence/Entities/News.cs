﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    public class News
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Headline { get; set; }

        public string? Content { get; set; }

        public string? ImageUrl { get; set; }
    }
}
