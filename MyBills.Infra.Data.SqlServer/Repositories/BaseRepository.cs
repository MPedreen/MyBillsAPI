using MyBills.Domain.Interfaces.Repositories;
using MyBills.Infra.Data.SqlServer.Contexts;

namespace MyBills.Infra.Data.SqlServer.Repositories
{
    public abstract class BaseRepository<TModel, TKey> : IBaseRepository
        where TModel : class
    {
        private readonly DataContext _dataContext;

        protected BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public virtual void Add(TModel model)
            => _dataContext.Add(model);

        public virtual void Update(TModel model)
            => _dataContext.Update(model);

        public virtual void Delete(TModel model)
            => _dataContext.Remove(model);

        public virtual List<TModel> GetAll()
            => _dataContext.Set<TModel>().ToList();

        public virtual List<TModel> GetAll(Func<TModel, bool> where)
            => _dataContext.Set<TModel>().Where(where).ToList();

        public virtual TModel GetById(TKey id)
            => _dataContext.Set<TModel>().Find(id);

        public virtual TModel Get(Func<TModel, bool> where)
            => _dataContext.Set<TModel>().FirstOrDefault(where);

        public void Dispose()
            => _dataContext.Dispose();
    }
}
