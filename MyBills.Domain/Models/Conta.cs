using MyBills.Domain.Models.Enums;

namespace MyBills.Domain.Models
{
    public class Conta
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public decimal Valor { get; set; }
        public TipoContaEnum Tipo { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool EstaPaga { get; set; }
    }
}
