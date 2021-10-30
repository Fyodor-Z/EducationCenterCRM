using System;
using System.Collections.Generic;
using System.Text;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.BLL.Models
{
    public class Lesson : BaseModel
    {
        public DateTime LessonDate { get; set; }
        public Guid GroupId { get; set; }

        public virtual StudentGroup Group { get; set; }

    }
}
