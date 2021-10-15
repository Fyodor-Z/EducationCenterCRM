using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.BLL.Models
{
    public class Topic: BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int? ParentId { get; set; }
        public Topic Parent { get; set; }
    }
}