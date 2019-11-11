using System;
using System.Collections.Generic;
using System.Text;

namespace Crushs
{
    class Comportamento
    {
        public string Descricao { get; set; }
        public int Intensidade { get; set; }

        //modificador 
        //privado e publico
        //faz com que somente a classe possa enxergar aquele método (algo interno, para que não possa ser acessado do lado de fora)
        //já o público é aberto 
        // este método quem o faz, é o crush, logo tem que ser público

        public void IncluirIntensidade(int intensidade)
        {
            Intensidade += intensidade;
        }

        public void DiminuirIntensidade(int intensidade)
        {
            Intensidade -= intensidade;
        }
    }
}
