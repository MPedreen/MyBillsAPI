using MediatR;
using MyBills.Application.Models.Commands;
using MyBills.Application.Models.Queries;

namespace MyBills.Application.Services
{
    public class ContaAppService
    {
        private readonly IMediator? _mediator;

        public ContaAppService(IMediator? mediator)
        {
            _mediator = mediator;
        }

        public async Task<ContaQuery> Create(ContaCreateCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<ContaQuery> Update(ContaUpdateCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<ContaQuery> Delete(ContaDeleteCommand command)
        {
            return await _mediator.Send(command);
        }

        // TODO
        //public List<ContaQuery> GetAll()
        //{
        //    return _produtoPersistence.GetAll();
        //}

        // TODO
        //public ContaQuery GetById(Guid? id)
        //{
        //    return _produtoPersistence.GetById(id.Value);
        //}
    }
}
