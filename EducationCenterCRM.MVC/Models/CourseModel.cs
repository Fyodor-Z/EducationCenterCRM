using System;
using System.ComponentModel.DataAnnotations;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.MVC.Models
{
    public class CourseModel : BaseModel
    {
        [Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter program")]
        public string Program { get; set; }
        [Required(ErrorMessage = "Please topic")]
        public Guid TopicId { get; set; }
        public TopicModel Topic { get; set; }

        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Please enter duration")]
        public int DurationWeeks { get; set; }
    }
}
