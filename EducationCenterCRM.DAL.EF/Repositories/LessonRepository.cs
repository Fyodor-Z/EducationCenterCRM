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
    public class LessonRepository: IRepository<Lesson>
    {
        private ApplicationContext Context { get; set; }
        public LessonRepository(ApplicationContext context)
        {
            Context = context;
        }

        public List<Lesson> GetAll()
        {
            return Context.Lessons.AsNoTracking().Include(s => s.Group).Include(s => s.Marks).ThenInclude(s => s.Student).ToList();
        }

        public async Task<List<Lesson>> GetAllAsync()
        {
            return await Context.Lessons.AsNoTracking().Include(s => s.Group).Include(s => s.Marks).ThenInclude(s => s.Student).ToListAsync();
        }

        public Lesson Create(Lesson lesson)
        {
            Context.Lessons.Add(lesson);
            Context.SaveChanges();
            var id = lesson.Id;
            return Get(id);
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.Lessons.FirstOrDefault(m => m.Id == id);
            if (toDelete != null)
            {
                Context.Lessons.Remove(toDelete);
                Context.SaveChanges();
            }
        }

        public Lesson Update(Lesson model)
        {
            Context.Entry(model).State = EntityState.Modified;
            Context.SaveChanges();
            var id = model.Id;
            return Get(id);
        }

        public Lesson Get(Guid id)
        {
            return Context.Lessons.Include(l => l.Group).ThenInclude(g =>g.Students).Include(l => l.Marks).ThenInclude(s => s.Student).FirstOrDefault(m => m.Id == id);
        }
    }
}
