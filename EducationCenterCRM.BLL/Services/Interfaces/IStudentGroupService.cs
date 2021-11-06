using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EducationCenterCRM.BLL.Models;

namespace EducationCenterCRM.BLL.Services.Interfaces
{
    public interface IStudentGroupService: IEntityService<StudentGroup>
    {
        byte[] ExportGroupMarks(Guid id, out string fileName);
    }
}
