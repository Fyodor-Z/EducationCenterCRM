using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.DAL;

namespace EducationCenterCRM.MVC.Models
{
    public abstract class PersonModel: BaseModel
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

        public string FullName
        {
            get
            {
                return string.Join(" ", this.FirstName, this.LastName);
            }
        }
    }
}
