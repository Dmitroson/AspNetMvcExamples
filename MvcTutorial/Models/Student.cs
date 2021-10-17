using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTutorial.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; }
        
        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}