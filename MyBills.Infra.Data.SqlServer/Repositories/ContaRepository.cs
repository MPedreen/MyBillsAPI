using MyBills.Domain.Interfaces.Repositories;
using MyBills.Domain.Models;
using MyBills.Infra.Data.SqlServer.Contexts;

namespace MyBills.Infra.Data.SqlServer.Repositories
{
    public class ContaRepository : BaseRepository<Conta, Guid>, IContaRepository
    {
        private readonly DataContext _dataContext;

        public ContaRepository(DataContext dataContext)
            : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
