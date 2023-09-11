using AutoMapper;
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

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        //private readonly IContaDomainService _contaDomainService;

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
