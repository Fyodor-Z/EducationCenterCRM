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
    public class StudentRequestRepository: IRepository<StudentRequest>
    {
        private ApplicationContext Context { get; set; }
        public StudentRequestRepository(ApplicationContext context)
        {
            Context = context;
        }

        public List<StudentRequest> GetAll()
        {
            return Context.StudentRequests.AsNoTracking().Include(s => s.Course).ToList();
        }

        public async Task<List<StudentRequest>> GetAllAsync()
        {
            return await Context.StudentRequests.AsNoTracking().Include(s => s.Course).ToListAsync();
        }

        public StudentRequest Create(StudentRequest course)
        {
            Context.StudentRequests.Add(course);
            Context.SaveChanges();
            var id = course.Id;
            return Get(id);
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.StudentRequests.FirstOrDefault(m => m.Id == id);
            if (toDelete != null)
            {
                Context.StudentRequests.Remove(toDelete);
                Context.SaveChanges();
            }
        }

        public StudentRequest Update(StudentRequest model)
        {
            Context.Entry(model).State = EntityState.Modified;
            Context.SaveChanges();
            var id = model.Id;
            return Get(id);
        }

        public StudentRequest Get(Guid id)
        {
            return Context.StudentRequests.Include(s => s.Course).FirstOrDefault(m => m.Id == id);
        }
    }
}
