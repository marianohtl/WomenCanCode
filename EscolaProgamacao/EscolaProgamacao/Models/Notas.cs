using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaProgamacao.Models
{
    public class Notas
    {
        public string CodigoTurma { get; set; }

        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }

        public bool Aprovado
        {
            get {
                var SomaNotas = Nota1 + Nota2 + Nota3;
                return SomaNotas == 0 ? false : SomaNotas / 3 >= 6;  
            }
        }
    }
}
