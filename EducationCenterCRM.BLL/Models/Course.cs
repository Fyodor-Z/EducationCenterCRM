using System;
using System.ComponentModel.DataAnnotations.Schema;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.BLL.Models
{
    public class Course: BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Program { get; set; }
        public Guid TopicId { get; set; }
        public Topic Topic { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public int DurationWeeks { get; set; }
    }
}