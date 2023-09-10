using MediatR;
using MyBills.Application.Interfaces.Persistences;
using MyBills.Application.Interfaces.Services;
using MyBills.Application.Models.Commands;
using MyBills.Application.Models.Queries;

namespace MyBills.Application.Services
{
    public class ContaAppService : IContaAppService
    {
        private readonly IMediator _mediator;
        private readonly IContaPersistence _contaPersistence;

        public ContaAppService(IMediator mediator, IContaPersistence contaPersistence)
        {
            _mediator = mediator;
            _contaPersistence = contaPersistence;
        }

        public async Task<ContaQuery> Create(ContaCreateCommand command)
            => await _mediator.Send(command);


        public async Task<ContaQuery> Update(ContaUpdateCommand command)
            => await _mediator.Send(command);


        public async Task<ContaQuery> Delete(ContaDeleteCommand command)
            => await _mediator.Send(command);

        public List<ContaQuery> GetAll()
            => _contaPersistence.GetAll();

        public ContaQuery GetById(Guid? id)
            => _contaPersistence.GetById(id.Value);
    }
}
