using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.MVC.Models
{
    public class StudentRequestModel: BaseModel
   {
       [Required(ErrorMessage = "Please enter name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please select course")]
        public Guid CourseId { get; set; }
        public CourseModel Course { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public RequestStatus Status { get; set; } = RequestStatus.Unprocessed;
        public string? Comments { get; set; }
        [EmailAddress(ErrorMessage = "Wrong e-mail format")]
        [Required(ErrorMessage = "Please enter e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        public string Phone { get; set; }
    }
}
