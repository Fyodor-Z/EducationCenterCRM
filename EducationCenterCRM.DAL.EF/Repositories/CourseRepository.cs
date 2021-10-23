using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.DAL.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EducationCenterCRM.DAL.EF.Repositories
{
    public class CourseRepository: IRepository<Course>
    {
        private ApplicationContext Context { get; set; }
        public CourseRepository(ApplicationContext context)
        {
            Context = context;
        }

        public List<Course> GetAll()
        {
            return Context.Courses.AsNoTracking().Include(s => s.Topic).ToList();
        }

        public async Task<List<Course>> GetAllAsync()
        {
            return await Context.Courses.AsNoTracking().Include(s => s.Topic).ToListAsync();
        }

        public Course Create(Course course)
        {
            Context.Courses.Add(course);
            Context.SaveChanges();
            var id = course.Id;
            return Get(id);
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.Courses.FirstOrDefault(m => m.Id == id);
            if (toDelete != null)
            {
                Context.Courses.Remove(toDelete);
                Context.SaveChanges();
            }
        }

        public Course Update(Course model)
        {
            Context.Entry(model).State = EntityState.Modified;
            Context.SaveChanges();
            var id = model.Id;
            return Get(id);
        }

        public Course Get(Guid id)
        {
            return Context.Courses.Include(s => s.Topic).FirstOrDefault(m => m.Id == id);
        }
    }
}
