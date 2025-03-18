﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contact : BaseEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; } 
    }
}
