using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.DAL.BaseModel;

namespace EducationCenterCRM.DAL
{
    public interface IRepository<TDbModel> where TDbModel : BaseModel.BaseModel
    {
        public List<TDbModel> GetAll();
        public Task<List<TDbModel>> GetAllAsync();
        public TDbModel Get(Guid id);
        public TDbModel Create(TDbModel model);
        public TDbModel Update(TDbModel model);
        public void Delete(Guid id);
    }
}
