using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestRepeat.Models
{
    public class Menu
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string FoodType { get; set; }

        public virtual Staff Manager { get; set; }
    }
}