using System;
using EducationCenterCRM.DAL;

namespace EducationCenterCRM.MVC.Models
{
    public class StudentGroupModel:BaseModel
    {
        public string Title { get; set; }
        public Guid? TeacherId { get; set; }
        public TeacherModel? Teacher { get; set; }
    }
}