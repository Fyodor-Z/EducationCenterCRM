using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.DAL;

namespace EducationCenterCRM.BLL.Services.Impl
{
    public class StudentService: IEntityService<Student>
    {
        private readonly IRepository<Student> _repository;

        public StudentService(IRepository<Student> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Student> GetAll()
        {
            return _repository.GetAll();
        }
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            var allStudents = await _repository.GetAllAsync();
            return allStudents.AsEnumerable();
        }

        public Student GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public Student Create(Student student)
        {
            return _repository.Create(student);
        }

        public Student Update(Student student)
        {
            return _repository.Update(student);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
