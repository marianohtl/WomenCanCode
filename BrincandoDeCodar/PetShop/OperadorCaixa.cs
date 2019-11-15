using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class OperadorCaixa : Funcionario
    {
        public decimal DiferenciaDescontoSalario { get; set; }

        public List<ControleDeCaixa> OperacaoCaixa { get; set; }


    }
}
