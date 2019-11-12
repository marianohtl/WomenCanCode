using System;
using System.Collections.Generic;
using System.Text;

namespace Crushs
{
    // colocamos a classe comportamento como interna , logo todas as classes que estiverem em qualquer outro projeto que não seja crush não pode ser vista
    //internal
  class Comportamento
    {
        public string Descricao { get; set; }
        public int Intensidade { get; set; }

        private int myVar;

        //alterando a regra e negócio conforme a necessidade 
        public int MyProperty
        {
            get { return myVar; }

            set {
                
                if(value < 5)
                {
                    myVar = 2;
                }
                
                myVar = value; }
        }


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
