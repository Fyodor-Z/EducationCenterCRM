using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services;
using EducationCenterCRM.DAL;
using EducationCenterCRM.DAL.EF;
using EducationCenterCRM.DAL.EF.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EducationCenterCRM.DAL.EF.Repositories
{
    public class StudentGroupRepository: IRepository<StudentGroup>
    {

        private ApplicationContext Context { get; set; }
        public StudentGroupRepository(ApplicationContext context)
        {
            Context = context;
        }

        public StudentGroup Create(StudentGroup studentGroup)
        {
            Context.StudentGroups.Add(studentGroup);
            Context.SaveChanges();
            var id = studentGroup.Id;
            return Get(id);
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.StudentGroups.FirstOrDefault(m => m.Id == id);
            if (toDelete != null)
            {
                Context.StudentGroups.Remove(toDelete);
                Context.SaveChanges();
            }
        }

        public List<StudentGroup> GetAll()
        {
            return Context.StudentGroups.AsNoTracking().Include(s => s.Teacher).Include(s => s.Students).ToList();
        }

        public async Task<List<StudentGroup>> GetAllAsync()
        {
            return await Context.StudentGroups.AsNoTracking().Include(s => s.Teacher).ToListAsync();
        }

        public StudentGroup Update(StudentGroup model)
        {
            Context.Entry(model).State = EntityState.Modified;
            Context.SaveChanges();
            var id = model.Id;
            return Get(id);
        }

        public StudentGroup Get(Guid id)
        {
            return Context.StudentGroups.Include(s => s.Teacher).Include(s => s.Students).FirstOrDefault(m => m.Id == id);
        }
    }
}

