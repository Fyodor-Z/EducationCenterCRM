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
    public class MarkService : IEntityService<Mark>
    {
        private readonly IRepository<Mark> _repository;

        public MarkService(IRepository<Mark> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Mark> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<Mark>> GetAllAsync()
        {
            var allMarks = await _repository.GetAllAsync();
            return allMarks.AsEnumerable();
        }

        public Mark GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public Mark Create(Mark mark)
        {
            _repository.Create(mark);
            return mark;
        }

        public Mark Update(Mark mark)
        {
            _repository.Update(mark);
            return mark;
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}

