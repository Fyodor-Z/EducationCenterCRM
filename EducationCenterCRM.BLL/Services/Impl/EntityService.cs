using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.BLL.Services.Interfaces;
using EducationCenterCRM.DAL;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.BLL.Services.Impl
{
    public class EntityService<TEntity> : IEntityService<TEntity> where TEntity: BaseModel
    {
        private readonly IRepository<TEntity> _repository;

        public EntityService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var allEntities = await _repository.GetAllAsync();
            return allEntities.AsEnumerable();

        }

        public TEntity GetById(Guid id)
        {
            return _repository.Get(id);
        }

        public TEntity Create(TEntity model)
        {
            return _repository.Create(model);
        }

        public TEntity Update(TEntity model)
        {
            return _repository.Update(model);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }


    }
}
