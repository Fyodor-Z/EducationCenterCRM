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
    public class MarkRepository: IRepository<Mark>
    {
        private ApplicationContext Context { get; set; }
        public MarkRepository(ApplicationContext context)
        {
            Context = context;
        }

        public List<Mark> GetAll()
        {
            return Context.Marks.AsNoTracking().Include(s => s.Student).Include(s => s.Lesson).ToList();
        }

        public async Task<List<Mark>> GetAllAsync()
        {
            return await Context.Marks.AsNoTracking().Include(s => s.Student).Include(s => s.Lesson).ToListAsync();
        }

        public Mark Create(Mark course)
        {
            Context.Marks.Add(course);
            Context.SaveChanges();
            var id = course.Id;
            return Get(id);
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.Marks.FirstOrDefault(m => m.Id == id);
            if (toDelete != null)
            {
                Context.Marks.Remove(toDelete);
                Context.SaveChanges();
            }
        }

        public Mark Update(Mark model)
        {
            Context.Entry(model).State = EntityState.Modified;
            Context.SaveChanges();
            var id = model.Id;
            return Get(id);
        }

        //public Mark UpdateScore(Mark model)
        //{
        //    Context.Entry(model).Property("Score").CurrentValue = model.Score;
        //    Context.SaveChanges();
        //    var id = model.Id;
        //    return Get(id);
        //}

        public Mark Get(Guid id)
        {
            return Context.Marks.Include(s => s.Student).Include(s => s.Lesson).ThenInclude(s => s.Group).FirstOrDefault(m => m.Id == id);
        }
    }
}

