﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo.Model
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
