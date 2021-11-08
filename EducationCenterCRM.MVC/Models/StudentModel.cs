using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;

namespace EducationCenterCRM.MVC.Models
{
    public class StudentModel : PersonModel
    {

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please choose start date")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; } = DateTime.Today;
        [Display(Name = "Group")]
        public virtual StudentGroupModel? StudentGroup { get; set; }
        public Guid? StudentGroupId { get; set; }
        public virtual IEnumerable<Mark> Marks { get; set; }

        public double AverageScore
        {
            get
            {
                if (Marks != null && Marks.Count() != 0)
                {
                    return Marks.Select(m => m.Score).Average();
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
