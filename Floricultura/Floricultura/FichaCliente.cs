using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    public class FichaCliente : DadosPessoa
    {
        public FichaCliente ()
        {
            kits = new Kits();
        }
        public string NumPedido { get; set; }

        public double ValorPedido { get; set; }

        public string CartaoCredito { get; set; }
        public bool Entrega { get; set; }

        public bool Presente { get; set; }
        public string DescricaoCartao { get; set; }
        public Kits kits { get; set; }




    }
}
