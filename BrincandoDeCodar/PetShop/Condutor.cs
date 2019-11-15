using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class Condutor
    {
        public string CategoriaCNH { get; set; }

        public string PlacaDoVeiculo { get; set; }

        public string ModeloCarro { get; set; }

        public string Cor { get; set; }

        public TipoVeiculo TipoVeiculo { get; set; }

        public string Renavan  { get; set; }
    }


    //lista pré determinada para obrigar a ter campos pré definidos
    public enum TipoVeiculo 
    {
           Carro,
           Moto,
           Caminhao

    }
}
