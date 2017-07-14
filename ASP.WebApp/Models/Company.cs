using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }

        public virtual Accountant Accountant { get; set; }
    }
}