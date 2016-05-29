using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestRepeat.Models
{
    public class Staff
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime HireDate { get; set; }

        public virtual Department Department { get; set; }

    }
}