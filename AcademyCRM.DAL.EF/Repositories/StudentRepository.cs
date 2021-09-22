using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.DAL;
using EducationCenterCRM.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace AcademyCRM.DAL.EF
{
    public class StudentRepository: IRepository<Student>
    {
        private ApplicationContext Context { get; set; }
        public StudentRepository(ApplicationContext context)
        {
            Context = context;
        }

        public Student Create(Student student)
        {
            Context.Students.Add(student);
            Context.SaveChanges();
            return student;
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.Students.FirstOrDefault(m => m.Id == id);
            if (toDelete != null)
            {
                Context.Students.Remove(toDelete);
                Context.SaveChanges();
            }
        }

        public List<Student> GetAll()
        {
            return Context.Students.AsNoTracking().Include(s => s.StudentGroup).ToList();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await Context.Students.AsNoTracking().Include(s => s.StudentGroup).ToListAsync();
        }

        public void Update(Student model)
        {
            Context.Entry(model).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public Student Get(Guid id)
        {
            return Context.Students.AsNoTracking().Include(s => s.StudentGroup).FirstOrDefault(m => m.Id == id);
        }
    }
}
