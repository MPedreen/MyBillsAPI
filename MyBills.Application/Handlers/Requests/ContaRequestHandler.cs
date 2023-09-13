using AutoMapper;
using MediatR;
using MyBills.Application.Models.Commands;
using MyBills.Application.Models.Queries;
using MyBills.Domain.Interfaces.Services;
using MyBills.Domain.Models;

namespace MyBills.Application.Handlers.Requests
{
    public class ContaRequestHandler :
        IRequestHandler<ContaCreateCommand, ContaQuery>,
        IRequestHandler<ContaUpdateCommand, ContaQuery>,
        IRequestHandler<ContaDeleteCommand, ContaQuery>
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IContaDomainService _contaDomainService;

        public ContaRequestHandler(IMediator mediator, IMapper mapper, IContaDomainService contaDomainService)
        {
            _mediator = mediator;
            _mapper = mapper;
            _contaDomainService = contaDomainService;
        }

        public async Task<ContaQuery> Handle(ContaCreateCommand request, CancellationToken cancellationToken)
        {
            var conta = _mapper.Map<Conta>(request);
            _contaDomainService.Add(conta);

            var contaQuery = _mapper.Map<ContaQuery>(conta);

            return contaQuery;
        }

        public Task<ContaQuery> Handle(ContaUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ContaQuery> Handle(ContaDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
