using System;
using System.Collections.Generic;
using System.Text;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.BLL.Models
{
    public class StudentRequest: BaseModel
    {
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public string? Comments { get; set; }

        public RequestStatus Status { get; set; }
    }
}
