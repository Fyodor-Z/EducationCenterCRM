using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.Models;
using EducationCenterCRM.Repositories.Interfaces;

namespace EducationCenterCRM.Services
{
    public class StudentService: IStudentService
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

        public Student GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public void Create(Student student)
        {
            _repository.Create(student);
        }

        public void Update(Student student)
        {
            _repository.Update(student);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
