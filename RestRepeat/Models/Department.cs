﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestRepeat.Models
{
    public class Department
    {
        public int ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }

        //public virtual ICollection<Staff> workers { get; set; }
    }
}