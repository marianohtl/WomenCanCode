using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    //aqui não podemos usar essa classe como objeto 
    public abstract class Pessoa
    {
        //instanciamos no consultor, ele não necessita ser instanciado depois
        public Pessoa()
        {
            MeuEndereco = new Endereco();
        }

        public int Id { get; set; }

        public  DateTime DataNascimento  { get; set; }

       public decimal Salario { get; set; }

        public  DateTime DataEntrada { get; set; }

        public  DateTime DataSaida { get; set; }

        public string CPF  { get; set; }
        public string email  { get; set; }
        public Endereco MeuEndereco { get; set; }

        private int _idade { get; set; }

       
        public int Idade
        {
            get
            {

                // operador ternário
                //string sobrenome == "gameiro"
                //string nome = sobrenome == "gameiro", "thamires",
                
                _idade = DateTime.Today.Year - DataNascimento.Year;
                return DataNascimento.AddYears(_idade) > DateTime.Today ? _idade -- : _idade;
                    
                    //DataNascimento.Month > DateTime.Today.Month ? _idade : DataNascimento.Day
                    
                    }

        }




    }
}
