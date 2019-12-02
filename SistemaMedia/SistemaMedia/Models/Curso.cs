using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMedia.Models
{
    public class Curso
    {
        public Curso(string nomecurso,double diasaula,double qnthoraaula) {
           NomeCurso = nomecurso;
           DiasAula = diasaula;
           QntHoraAula = qnthoraaula;
      
        }

        public Curso()
        {
            NomeCurso = "Fazendo Minçangas";
            DiasAula = 10;
            QntHoraAula = 4;
        }
        public string NomeCurso { get; set; }

        public double DiasAula { get; set; } = 0;

        public double QntHoraAula { get; set; } = 0;
        public double CargaHorariaTotal { 
            get 
            { 
                var Total = QntHoraAula * DiasAula;
                return Total;
            }
        }








    }
}
