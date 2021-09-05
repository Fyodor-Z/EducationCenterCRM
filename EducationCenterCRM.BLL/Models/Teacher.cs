using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.BLL
{
    public class Teacher: Person
    {
        public string? Bio { get; set; }
        public string LinkToProfile { get; set; }
    }
}
