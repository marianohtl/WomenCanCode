using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class Endereco
    {
        public int Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //com este ? , ele aceita a ausência de informação
        public int? NumeroAndar { get; set; }
    }
}
