using MyBills.Application.Models.Commands;
using MyBills.Application.Models.Queries;

namespace MyBills.Application.Interfaces.Services
{
    public interface IContaAppService
    {
        Task<ContaQuery> Create(ContaCreateCommand command);
        Task<ContaQuery> Update(ContaUpdateCommand command);
        Task<ContaQuery> Delete(ContaDeleteCommand command);

        List<ContaQuery> GetAll();
        ContaQuery GetById(Guid? id);
    }
}
