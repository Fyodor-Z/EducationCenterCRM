using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.MVC.Models
{
    public abstract class PersonModel: BaseModel
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Please enter name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please choose birth date")]
        [DataType(DataType.Date)]
        [Display (Name = "Birth Date")]
        public DateTime BirthDate { get; set; } = new DateTime(1990, 1, 1);

        [Required(ErrorMessage = "Please choose gender")]
        public Gender Gender { get; set; }

        [EmailAddress(ErrorMessage = "Wrong e-mail format")]
        [Required(ErrorMessage = "Please enter e-mail")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Display(Name = "Name")]
        public string FullName => string.Join(" ", this.FirstName, this.LastName);
    }
}
