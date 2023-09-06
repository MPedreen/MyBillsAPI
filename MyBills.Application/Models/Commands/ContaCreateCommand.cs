using MediatR;
using MyBills.Application.Models.Queries;
using MyBills.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyBills.Application.Models.Commands
{
    public class ContaCreateCommand : IRequest<ContaQuery>
    {
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public TipoContaEnum Tipo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public bool EstaPaga { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataVencimento { get; set; }
    }
}
