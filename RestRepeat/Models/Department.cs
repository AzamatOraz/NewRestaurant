﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestRepeat.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Staff> workers { get; set; }
    }
}