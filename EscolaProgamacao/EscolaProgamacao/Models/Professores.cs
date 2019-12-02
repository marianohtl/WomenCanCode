using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaProgamacao.Models
{
    public class Professores : Pessoa
    {
        public Graduacao MinhaGraduacao { get; set; }

        public List<Materia> TipoAula { get; set; }

        public decimal Salario { get; set; }

        public int MyProperty { get; set; }

        public List<Turno> TurnoDisponivel { get; set; }


    }
}
