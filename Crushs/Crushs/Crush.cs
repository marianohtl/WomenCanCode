using System;
using System.Collections.Generic;
using System.Text;

namespace Crushs
{
    class Crush
    {
        public string Apelido { get; set; }
        public string Telefone { get; set; }
        public string Local { get; set; }
        public EstadoCivil EstadoCivilCrush { get; set; }

        public int Avaliacao { get; set; }

        public List<Comportamento> Comportamentos{ get; set; }
    }

//enum lista pre definida para limitar as possibilidades de escolhas
        public enum EstadoCivil {
                Solteiro,
                Namorando,
                Noivo,
                Casado,
                Divorciado,
                Viuvo
        }
}
