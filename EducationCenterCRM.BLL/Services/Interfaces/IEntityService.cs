using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.BLL.Services
{
    public interface IEntityService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
        TEntity GetById(Guid id);
        TEntity Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}
