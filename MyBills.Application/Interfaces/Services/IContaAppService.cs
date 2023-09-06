using MyBills.Application.Models.Commands;
using MyBills.Application.Models.Queries;

namespace MyBills.Application.Interfaces.Services
{
    public interface IContaAppService
    {
        Task<ContaQuery> Create(ContaCreateCommand command);
        Task<ContaQuery> Update(ContaCreateCommand command);
        Task<ContaQuery> Delete(ContaCreateCommand command);
        Task<ContaQuery> GetAll(ContaCreateCommand command);
        Task<ContaQuery> GetAll();
        Task<ContaQuery> GetById(Guid? id);
    }
}
