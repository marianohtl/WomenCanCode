using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaProgamacao.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string CPF { get; set; }

        public string email { get; set; }

        public Endereco MeuEndereco { get; set; }


    }
}
