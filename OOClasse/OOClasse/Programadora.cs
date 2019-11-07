using System;
using System.Collections.Generic;
using System.Text;

namespace OOClasse
{

    //programadora herdará pessoa
    class Programadora : Pessoa
    {
        //método que executa todas as vezes que executamos a classe CONSULTOR  (ELE É DEFAULT)

        //    ctor > atalho para public ...
        public Programadora(int anosCarreira, bool possuirGraduacao)
        {
            //Aqui temos alguns exemplos obrigando passarem parâmetros
            Linguagens = new List<string>();
            AnosDeCarreira = AnosDeCarreira;
            PossuiGraduacao = PossuiGraduacao;
        }

        //outro consultor 
        public Programadora()
        {

        }
        public List<string> Linguagens { get; set; }

        public int AnosDeCarreira { get; set; }

        public bool PossuiGraduacao { get; set; }

        public bool TrabalhaNaArea { get; set; }

        public decimal Salario { get; set; }





    }
}
