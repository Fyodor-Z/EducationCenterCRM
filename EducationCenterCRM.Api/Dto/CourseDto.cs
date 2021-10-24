using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.Api.Dto
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Program { get; set; }
        public Guid TopicId { get; set; }
        public string TopicName { get; set; }
    }
}
