using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.MVC.Models
{
    public class LessonModel: BaseModel
    {

        [DataType(DataType.Date)]
        [Display(Name = "Lesson Date")]
        public DateTime LessonDate { get; set; } = DateTime.Today;
        [Required(ErrorMessage = "Please choose group")]
        public Guid GroupId { get; set; }

        public StudentGroupModel Group { get; set; }
        public virtual IEnumerable<MarkModel> Marks { get; set; }

    }
}

