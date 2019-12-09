using SistemaMedia.Repositorio;
using System;
using System.Collections.Generic;

namespace SistemaMedia.Models
{
    public class Aluno : Turma
    {
        private AlunoRepositorio repo;
        public Aluno(int id,string nome,int idade,bool presencadiaria) {

            Id = id;
            Nome = nome;
            Idade = idade;
            PresencaDiaria = presencadiaria;
            Curso = new Curso();
        }

        public Aluno() {
         
            TotalPresencaCalc();
            repo = new AlunoRepositorio();
        }

        public List<Aluno> RetornarAlunos()
        {
            return repo.SelecionarAlunos();
        }

       
        public int Id { get; set; }
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Notas Notas { get; set; }

        public Turma Turma { get; set; }

        public Curso Curso { get; set; }

        public bool PresencaDiaria { get; set; } = false;

        public int TotalPresenca { get; set; } = 0;

       public bool ReprovadoFaltas { get; set; } = false;

        public void TotalPresencaCalc() {
         var totalPresenca =  TotalPresenca;

           if (totalPresenca == 0 && PresencaDiaria == true)
           {
               totalPresenca = 1;
           }
           if (PresencaDiaria == true && totalPresenca > 1)
            {
               totalPresenca += totalPresenca;
           }
            TotalPresenca = totalPresenca;
        }
        

        public void Faltas() {
            double porcento = 0.25;
            // porcentagem de faltas permitidas em horas
           
           
            var faltasPermitidas = porcento * Curso.CargaHorariaTotal;
           var reprovar = TotalPresenca - faltasPermitidas;

           if (reprovar < 0) {
                ReprovadoFaltas = true;
           }
           else
            {
                ReprovadoFaltas = false;
           }
        }

    }
}
