using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.DAL;

namespace EducationCenterCRM.BLL.Services.Impl
{

    public class TeacherService : IEntityService<Teacher>
    {
        private readonly IRepository<Teacher> _repository;

        public TeacherService(IRepository<Teacher> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<Teacher>> GetAllAsync()
        {
            var allTeachers = await _repository.GetAllAsync();
            return allTeachers.AsEnumerable();
        }


        public Teacher GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public Teacher Create(Teacher teacher)
        {
            return _repository.Create(teacher);
        }

        public Teacher Update(Teacher teacher)
        {
            return _repository.Update(teacher);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}

