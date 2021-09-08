using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL;
using EducationCenterCRM.DAL;
using EducationCenterCRM.Services;

namespace EducationCenterCRM.BLL
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
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            var allStudents = await _repository.GetAllAsync();
            return allStudents.AsEnumerable();
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
