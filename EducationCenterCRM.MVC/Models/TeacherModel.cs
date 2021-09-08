using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.MVC.Models
{
    public class TeacherModel: PersonModel
    {
        public string? Bio { get; set; }
        public string LinkToProfile { get; set; }
    }
}
