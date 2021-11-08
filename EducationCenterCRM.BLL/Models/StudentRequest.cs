using System;
using System.Collections.Generic;
using System.Text;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.BLL.Models
{
    public class StudentRequest: BaseModel
    {
       
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid CourseId { get; set; }
        public Course Course { get; set; }
       
        public DateTime Created { get; set; }

        public RequestStatus Status { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string? Comments { get; set; }
    }
}
