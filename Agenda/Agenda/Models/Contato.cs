using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Contato
    {

        public Contato(string nome, string celular,string email, 
            string comercial = null, string fixo = null, string apelido = null)
        {
            Nome = nome;
            Celular = celular;
            Email = email;
            //as  duas interrogações confirma se o valor está nullo ()
            //as interrogações servem apenas quando o parâmetro é nullo
            Comercial = comercial ?? string.Empty;
            Fixo = fixo ?? string.Empty;
            Apelido = apelido ?? string.Empty;

        }
        public string Nome { get; set; }
        public string Celular { get; set; }

        public string Comercial { get; set; }

        public string Fixo { get; set; }

        public string Email { get; set; }

        public string Apelido { get; set; }
    }
}
