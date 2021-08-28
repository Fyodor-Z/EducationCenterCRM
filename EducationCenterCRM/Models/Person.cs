using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.Models
{
    public abstract class Person: BaseModel
    {
        [Required(ErrorMessage = "Please enter name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please choose birth date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Please choose gender")]
        public Gender Gender { get; set; }
    }
}
