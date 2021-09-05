using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using EducationCenterCRM.DAL;
using EducationCenterCRM.Services;

namespace EducationCenterCRM.BLL
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

        public void Create(TEntity model)
        {
            _repository.Create(model);
        }

        public void Update(TEntity model)
        {
            _repository.Update(model);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }


    }
}
