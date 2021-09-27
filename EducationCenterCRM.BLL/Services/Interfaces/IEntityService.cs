using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationCenterCRM.BLL.Services.Interfaces
{
    public interface IEntityService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
        TEntity GetById(Guid id);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(Guid id);
    }
}
