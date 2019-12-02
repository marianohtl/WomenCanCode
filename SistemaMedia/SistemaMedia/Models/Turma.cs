using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMedia.Models
{
    public class Turma
    {
      
        
        public Turma()
        {
            IdTurma = 1;
            Sigla = "B";
            Turno = "Manhã";
            QntdAlunos = 150;
        }


        public int IdTurma { get; set; }
        public string Sigla { get; set; }
        public string Turno { get; set; }
        public int QntdAlunos { get; set; }
        //public List<Aluno> Alunos { get; set; }


    }
}
