using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Models;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.DAL;

namespace EducationCenterCRM.BLL.Services.Impl
{
    public class LessonService: IEntityService<Lesson>
    {
        private readonly IRepository<Lesson> _repository;

        public LessonService(IRepository<Lesson> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Lesson> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<Lesson>> GetAllAsync()
        {
            var allLessons = await _repository.GetAllAsync();
            return allLessons.AsEnumerable();
        }

        public Lesson GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public Lesson Create(Lesson group)
        {
            _repository.Create(group);
            return group;
        }

        public Lesson Update(Lesson group)
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

