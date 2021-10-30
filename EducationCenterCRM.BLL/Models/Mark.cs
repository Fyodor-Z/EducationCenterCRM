using System;
using System.Collections.Generic;
using System.Text;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.BLL.Models
{
    public class Mark: BaseModel
    {
        public Guid LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public int Score { get; set; }
    }
}
