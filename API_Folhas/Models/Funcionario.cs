using System;

namespace API_Folhas.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}