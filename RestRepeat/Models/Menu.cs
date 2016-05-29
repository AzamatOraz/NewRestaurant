﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestRepeat.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string FoodType { get; set; }

        public virtual Staff Manager { get; set; }
    }
}