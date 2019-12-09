using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaMedia.Repositorio;


namespace SistemaMedia.Models
{
    public class Notas
    {
        private AlunoRepositorio repo;
        public Notas() {
            CalcMedia(SomaNotas);
         }

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public bool NotasPreenchidas
        {
            get{
                if (Nota1 == null || Nota2 == null || Nota3 == null || Nota4 == null)
                {
                    return false;
                }
                return true;

            }
        }
        public double SomaNotas {
            get {
                var SomaNotas = Nota1 + Nota2 + Nota3 + Nota4;
                return SomaNotas;
            }
        }

        public double Media { get; set; }
        public string CalcMedia(double  SomaNotas)
        {
            if (NotasPreenchidas == true)
            {
                var Media = SomaNotas / 4;
                if(Media >= 7)
                {
                    return $"Situração: Aprovado. Sua média é {Media}.";
                }
                return $"Situração: Reprovado. Sua média é {Media}.";
            }
            return "Situalção: Pendente";
        }
    }

}
