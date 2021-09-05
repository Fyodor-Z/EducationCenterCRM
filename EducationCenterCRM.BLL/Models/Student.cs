using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.BLL
{
    public class Student: Person
    {

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please choose start date")]
        public DateTime StartDate { get; set; }
    }
}
