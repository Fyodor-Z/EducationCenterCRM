using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.BLL.Models
{
    public abstract class Person: BaseModel
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
