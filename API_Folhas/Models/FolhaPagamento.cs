using System;
using System.ComponentModel.DataAnnotations;
using API_Folhas.Validations;

namespace API_Folhas.Models
{
    public class FolhaPagamento : Funcionario
    {

        public int FolhaPagamentoId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        [StringLength(
            11, //Máximo de caracteres
            MinimumLength = 11,
            ErrorMessage = "O cpf deve conter 11 caracteres!"
        )]
        [CpfEmUso]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O campo mês é obrigatório!")]
        [StringLength(
            3, //Máximo de caracteres
            MinimumLength = 3,
            ErrorMessage = "deve-se digitar os três primeiros digitos do mês (exemplo: JAN -> Janeiro)"
        )]
        public string Mes { get; set; }

        [Required(ErrorMessage = "O campo ano é obrigatório!")]
        [StringLength(
            4, //Máximo de caracteres
            MinimumLength = 4,
            ErrorMessage = "deve-se digitar o ano (exemplo: 2022)"
        )]
        public string Ano { get; set; }

        public int valorHora{get; set; }

        public int quantidadeDeHoras{get; set; }
    
        public int salarioBruto {get; set; }

        public int impostoRenda{get; set; }

        public int impostoInss{get; set; }

        public int impostoFgts{get; set; }

        public int salarioLiquido{get; set; }

        public Funcionario funcionario { get; set;}
    }
}