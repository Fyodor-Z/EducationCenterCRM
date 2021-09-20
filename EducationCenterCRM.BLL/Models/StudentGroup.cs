using System;
using System.Collections.Generic;
using System.Text;
using EducationCenterCRM.DAL;

namespace EducationCenterCRM.BLL.Models
{
    public class StudentGroup: BaseModel
    {
        public string Title { get; set; }
        public Guid? TeacherId { get; set; }
        public virtual Teacher? Teacher { get; set; }

        public virtual IEnumerable<Student> Students { get; set; }
    }
}
