using SistemaMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMedia.Repositorio
{
    public class AlunoRepositorio
    {
        //simulando uma tabela de banco de dados
        List<Aluno> Aluno;
   
        private void CriarAluno()
        {
            Aluno = new List<Aluno>();
            Aluno.Add(new Aluno(1,"Zézinho", 10,true));
        }

 
        public AlunoRepositorio()
        {
            CriarAluno();
            Aluno[0].TotalPresencaCalc();
            Aluno[0].Faltas();
           
        }

        public List<Aluno> SelecionarAlunos()
        {
            return Aluno;
        }

    }
}
