using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMedia.Models
{
    public class Notas
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public string NotasPreenchidas
        {
            get{
                if (Nota1 == null || Nota2 == null || Nota3 == null || Nota4 == null)
                {
                    return "Pendente";
                }
                return "Notas Preenchidas";

            }
        }
        public double SomaNotas {
            get {
                var SomaNotas = Nota1 + Nota2 + Nota3 + Nota4;
                return SomaNotas;
            }
        }

        public double Media {
            get
            {
                if (Nota1 != null && Nota2 != null && Nota3 != null && Nota4 != null) {
                    var Media = SomaNotas / 4;
                    return Media;
                } else
                {
                    return -1;
                }
            }
        }
    }
}
