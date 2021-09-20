using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;

namespace EducationCenterCRM.MVC.Models
{
    public class StudentModel: PersonModel
    {

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please choose start date")]
        public DateTime StartDate { get; set; }
        public virtual StudentGroupModel StudentGroup { get; set; }
        public Guid StudentGroupId { get; set; }
    }
}
