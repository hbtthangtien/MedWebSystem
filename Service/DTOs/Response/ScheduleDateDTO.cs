﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class ScheduleDateDTO
    {
        public int Id { get; set; }

        public DateOnly Date { get; set; }
    }
}
