using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class ControleDeCaixa
    {
        public decimal ValorAberturaCaixa { get; set; }
        public decimal ValorFechamentoCaixa { get; set; }
        public decimal ValorEmCaixaFechamento { get; set; }
        public DateTime DateAbertura { get; set; }
        public DateTime DateFechamento { get; set; }

        public decimal Sangria { get; set; }

        public decimal QuebraCaixa { get; set; }
    }
}
