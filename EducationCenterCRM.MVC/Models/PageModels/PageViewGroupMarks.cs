using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.MVC.Models.PageModels
{
    public class PageViewGroupMarks : BaseModel
    {
        public PageViewGroupMarks(Guid id, string title, IEnumerable<StudentModel> students, IEnumerable<LessonModel> lessons, string course, int pageNumber, int pageSize)
        {
            Id = id;
            Title = title;
            Lessons = lessons.OrderBy(l => l.LessonDate).Skip(pageSize*(pageNumber - 1)).Take(pageSize);
            Students = students;
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(lessons.Count() / (double)pageSize);
            Course = course;
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }
        public string Title { get; set; }
        public IEnumerable<StudentModel> Students { get; set; }
        public IEnumerable<LessonModel> Lessons { get; set; }

        public string Course { get; set; }

        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; }
    }
}
