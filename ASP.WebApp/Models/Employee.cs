using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please set a name")]
        [StringLength(150)]
        public string Name { get; set; }

        public DateTime MedicalExamDate { get; set; }

        public virtual Company Company { get; set; }

    }
}