using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenterCRM.BLL
{
    public interface IEntityService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}
