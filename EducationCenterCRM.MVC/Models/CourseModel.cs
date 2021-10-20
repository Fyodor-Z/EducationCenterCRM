using System;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.MVC.Models
{
    public class CourseModel: BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Program { get; set; }
        public Guid TopicId { get; set; }
        public TopicModel Topic { get; set; }

        public decimal? Price { get; set; }
        public int DurationWeeks { get; set; }
    }
}
