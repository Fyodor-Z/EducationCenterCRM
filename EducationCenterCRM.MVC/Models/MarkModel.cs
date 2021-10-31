using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.MVC.Models
{
    public class MarkModel : BaseModel
    {
        public Guid LessonId { get; set; }
        public LessonModel Lesson { get; set; }
        public Guid StudentId { get; set; }
        public StudentModel Student { get; set; }
        [Range(1, 10, ErrorMessage = "Score has to be from 1 to 10")]
        public int Score { get; set; }
    }
}

