using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.DAL;

namespace EducationCenterCRM.BLL.Services
{
    public class StudentGroupService:IStudentGroupService
    {

        private readonly IRepository<StudentGroup> _repository;

        public StudentGroupService(IRepository<StudentGroup> repository)
        {
            _repository = repository;
        }

        public IEnumerable<StudentGroup> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<StudentGroup>> GetAllAsync()
        {
            var allStudents = await _repository.GetAllAsync();
            return allStudents.AsEnumerable();
        }

        public StudentGroup GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public StudentGroup Create(StudentGroup group)
        {
            _repository.Create(group);
            return group;
        }

        public StudentGroup Update(StudentGroup group)
        {
            _repository.Update(group);
            return group;
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }

}