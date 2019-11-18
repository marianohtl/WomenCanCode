using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    public abstract class DadosPessoa
    {
        public DadosPessoa()
        {
            End = new Endereco();
        }

        public string Nome { get; set; }

        public string CPF { get; set; }
        public string RG { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public DateTime DataNascimento { get; set; }
        public Endereco End { get; set; }

        public  int idadeAtual { get; set; }

        public int Idade
        {
            get
            {
                idadeAtual = DateTime.Today.Year - DataNascimento.Year;
                return DataNascimento.AddYears(idadeAtual) > DateTime.Today ? idadeAtual-- : idadeAtual;
            }

        }


    }
}
