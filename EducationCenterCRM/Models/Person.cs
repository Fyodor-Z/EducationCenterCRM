using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.Models
{
    public abstract class Person
    {
        [Required(ErrorMessage = "Please enter name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please choose birth date")]
        public DateTime BirthDate { get; set; }
        
    }
}
