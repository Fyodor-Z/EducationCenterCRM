using System;
using System.Collections.Generic;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.BLL.Models
{
    public class StudentGroup : BaseModel
    {
        public string Title { get; set; }
        public Guid? TeacherId { get; set; }
        public virtual Teacher? Teacher { get; set; }

        public Guid CourseId { get; set; }
        public virtual Course Course { get; set; }

        public GroupStatus Status { get; set; }

        public virtual IEnumerable<Student> Students { get; set; }

    }

   
}
