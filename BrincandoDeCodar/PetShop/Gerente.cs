using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    class Gerente : Funcionario
    {
        public List<Funcionario> Subordinados { get; set; }

        public string Departamento { get; set; }
    }
}
