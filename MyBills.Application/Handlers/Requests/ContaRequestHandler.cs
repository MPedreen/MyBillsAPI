using AutoMapper;
using MediatR;
using MyBills.Application.Models.Commands;
using MyBills.Application.Models.Queries;
using MyBills.Application.Notifications;
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
            await _mediator.Publish(
                new ContaNotification
                {
                    Action = ActionNotificationEnum.Create,
                    Conta = contaQuery
                });

            return contaQuery;
        }

        public async Task<ContaQuery> Handle(ContaUpdateCommand request, CancellationToken cancellationToken)
        {
            var conta = _contaDomainService.GetById(request.Id.Value);
            conta.Numero = request.Numero;
            conta.Valor = request.Valor;
            conta.Tipo = request.Tipo;
            conta.EstaPaga = request.EstaPaga;
            conta.DataVencimento = request.DataVencimento;

            _contaDomainService.Update(conta);

            var contaQuery = _mapper.Map<ContaQuery>(conta);
            await _mediator.Publish(
                new ContaNotification
                {
                    Action = ActionNotificationEnum.Update,
                    Conta = contaQuery
                });

            return contaQuery;
        }

        public async Task<ContaQuery> Handle(ContaDeleteCommand request, CancellationToken cancellationToken)
        {
            var conta = _contaDomainService.GetById(request.Id.Value);
            _contaDomainService.Delete(conta);

            var contaQuery = _mapper.Map<ContaQuery>(conta);
            await _mediator.Publish(
                new ContaNotification
                {
                    Action = ActionNotificationEnum.Delete,
                    Conta = contaQuery
                });

            return contaQuery;
        }
    }
}
