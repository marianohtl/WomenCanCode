using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class Funcionario : Pessoa
    {
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }

        public decimal Salario { get; set; }

        public string CodigoCracha { get; set; }
        public Cargos Cargo { get; set; }

        public enum Cargos
        {
            Vendedor,
            Vendedora,
            Faxineira,
            Veterinária,
            Veterinário,
            Tosador,
            Motorista,
            OperadoraCaixa,
            Recepcionista,
            Trainee,
            Estagiario,
            Gerente


        }
    }
}
