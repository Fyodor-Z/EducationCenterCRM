using System;
using System.Collections.Generic;

namespace EducationCenterCRM.BLL.Models
{
    public class Student: Person
    {
        public DateTime StartDate { get; set; }
        public virtual StudentGroup? StudentGroup { get; set; }

        public Guid? StudentGroupId { get; set; }
        public virtual IEnumerable<Mark> Marks { get; set; }
    }
}
