using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class Atendente : Funcionario
    {
        public decimal ValorMensalVendido { get; set; }

        public decimal Meta { get => 2000; }

        public decimal PorcentagemComissao { get => 5;}

        


    }
}
