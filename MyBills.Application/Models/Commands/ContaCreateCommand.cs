using MediatR;
using MyBills.Application.Models.Queries;
using MyBills.Domain.Models.Enums;

namespace MyBills.Application.Models.Commands
{
    public class ContaCreateCommand : IRequest<ContaQuery>
    {
        public string Numero { get; set; }
        public decimal Valor { get; set; }
        public TipoContaEnum Tipo { get; set; }
        public bool EstaPaga { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
