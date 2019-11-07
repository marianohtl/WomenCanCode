using System;
using System.Collections.Generic;
using System.Text;

namespace OOClasse
{
    class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        //propriedade endereço é a que criamos , tipo uma string , está é tipo um endereço
        public  Endereco MeuEndereco { get; set; }

        public string NomeDaMae { get; set; }
    }
}
