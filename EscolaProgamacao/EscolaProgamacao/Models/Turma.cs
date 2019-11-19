using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaProgamacao.Models
{
    public class Turma
    {
        public string Codigo { get; set; }
        public Turno TurnoDeAula { get; set; }

        public List<Materia> MinhasMaterias { get; set; }

        public Professores ProfessorDaTurma { get; set; }

        public List<Aluno> TodosOsAlunos { get; set; }



    }
}
