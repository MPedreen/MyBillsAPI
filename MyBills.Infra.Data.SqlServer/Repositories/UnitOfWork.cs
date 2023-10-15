using MyBills.Domain.Interfaces.Repositories;
using MyBills.Infra.Data.SqlServer.Contexts;

namespace MyBills.Infra.Data.SqlServer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IContaRepository ContaRepository => new ContaRepository(_dataContext);

        public void SaveChanges()
            => _dataContext.SaveChanges();

        public void Dispose()
            => _dataContext.Dispose();
    }
}
