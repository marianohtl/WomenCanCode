using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class Despesas
    {
        public double Aluguel { get; set; } = 0 ;
        
        public double Agua { get; set; } = 0 ;

        public double Luz { get; set; } = 0 ;

        public  double Telefone { get; set; } = 0 ;

        public double Internet { get; set; }  = 0 ;

        public double Convenio { get; set; }  = 0 ;

        public double Medicamentos { get; set; }  = 0 ;

        public double Seguro { get; set; }  = 0 ;
        
        public double  Mercado { get; set; }  = 0 ;

        public double Roupas { get; set; }  = 0 ;

        public double Escola { get; set; }  = 0 ;

        public double MaterialEscolar { get; set; }  = 0 ;
        
        public double Brinquedos { get; set; }  = 0 ;

        public double Eletrodomesticos { get; set; }  = 0 ;

        public double EletroEletronicos { get; set; }  = 0 ;

        public double ItensCozinha { get; set; } = 0 ;
        public double Gas { get; set; } = 0 ;

        public double Lazer { get; set; } = 0 ;

        public double Transporte { get; set; } = 0 ;

        public double CartaoCredito { get; set; } = 0 ;
        public void CalcularDespesas(){
           
         var despesas = Aluguel + Agua + Luz + Telefone + Internet + Convenio + Medicamentos + Seguro + Mercado + Roupas + Escola + MaterialEscolar + Brinquedos + Eletrodomesticos + EletroEletronicos + ItensCozinha + Gas + Lazer +
         +Transporte + CartaoCredito;
                        
          Console.WriteLine($"R${despesas}"); 

        }
    }
}
