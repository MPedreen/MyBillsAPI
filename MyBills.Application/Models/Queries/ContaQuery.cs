using MyBills.Domain.Models.Enums;

namespace MyBills.Application.Models.Queries
{
    public class ContaQuery
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public decimal Valor { get; set; }
        public TipoContaEnum Tipo { get; set; }
        public bool EstaPaga { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataHoraCriacao { get; set; }
    }
}
