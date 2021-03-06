using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.MVC.Models
{
    public class StudentGroupModel:BaseModel
    {
        //[RegularExpression(@"\w{2,5}_[1-3]\d-[1-9]", ErrorMessage = "Please use pattern course_yy-n, where yy is year, n is group number")]
        [Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }
        public Guid? TeacherId { get; set; }
        public TeacherModel? Teacher { get; set; }
        public virtual IEnumerable<StudentModel> Students { get; set; }
        public virtual IEnumerable<LessonModel> Lessons { get; set; }

        public Guid CourseId {get; set; }

        public virtual CourseModel Course { get; set; }
    }
}