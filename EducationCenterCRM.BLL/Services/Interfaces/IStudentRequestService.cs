using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EducationCenterCRM.BLL.Models;

namespace EducationCenterCRM.BLL.Services.Interfaces
{
    public interface IStudentRequestService : IEntityService<StudentRequest>
    {
        StudentRequest ChangeStatus(Guid id);
    }
}
