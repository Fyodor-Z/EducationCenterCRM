using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationCenterCRM.DAL.EF.Contexts;
using Microsoft.EntityFrameworkCore;
using EducationCenterCRM.DAL.BaseModel;


namespace EducationCenterCRM.DAL.EF.Repositories
{
    public class BaseRepository<TDbModel> : IRepository<TDbModel> where TDbModel : BaseModel.BaseModel
    {
        private ApplicationContext Context { get; set; }
        public BaseRepository(ApplicationContext context)
        {
            Context = context;
        }

        public TDbModel Create(TDbModel model)
        {
            Context.Set<TDbModel>().Add(model);
            Context.SaveChanges();
            var id = model.Id;
            return Get(id);
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.Set<TDbModel>().FirstOrDefault(m => m.Id == id);
            if (toDelete != null)
            {
                Context.Set<TDbModel>().Remove(toDelete);
                Context.SaveChanges();
            }
        }

        public List<TDbModel> GetAll()
        {
            return Context.Set<TDbModel>().AsNoTracking().ToList();
        }

        public async Task<List<TDbModel>> GetAllAsync()
        {
            return await Context.Set<TDbModel>().AsNoTracking().ToListAsync();
        }

        public TDbModel Update(TDbModel model)
        {
            Context.Entry(model).State = EntityState.Modified;
            Context.SaveChanges();
            var id = model.Id;
            return Get(id);
        }

        public TDbModel Get(Guid id)
        {
            return Context.Set<TDbModel>().FirstOrDefault(m => m.Id == id);
        }
    }
}
