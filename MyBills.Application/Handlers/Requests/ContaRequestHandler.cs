using MediatR;
using MyBills.Application.Models.Commands;
using MyBills.Application.Models.Queries;

namespace MyBills.Application.Handlers.Requests
{
    public class ContaRequestHandler :
        IRequestHandler<ContaCreateCommand, ContaQuery>,
        IRequestHandler<ContaUpdateCommand, ContaQuery>,
        IRequestHandler<ContaDeleteCommand, ContaQuery>
    {
        public Task<ContaQuery> Handle(ContaCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ContaQuery> Handle(ContaDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ContaQuery> Handle(ContaUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
