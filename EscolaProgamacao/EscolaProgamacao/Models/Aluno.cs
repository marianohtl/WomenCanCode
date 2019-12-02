using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaProgamacao.Models
{
    public class Aluno : Pessoa
    {
        public List<Turma> Turma { get; set; }

        public decimal Mensalidade { get; set; }


    }
}
