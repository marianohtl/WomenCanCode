using Agenda.Repositorio;
using System.Collections.Generic;

namespace Agenda.Models
{
    public class Contato
    {
        private ContatoRepositorio repo ;
        public Contato(int id,string nome, string celular,string email, 
            string comercial = null, string fixo = null, string apelido = null)
        {
            Id = id;
            Nome = nome;
            Celular = celular;
            Email = email;
            //as  duas interrogações confirma se o valor está nullo ()
            //as interrogações servem apenas quando o parâmetro é nullo
            Comercial = comercial ?? string.Empty;
            Fixo = fixo ?? string.Empty;
            Apelido = apelido ?? string.Empty;

        }

        public Contato()
        {
            repo = new ContatoRepositorio();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }

        public string Comercial { get; set; }

        public string Fixo { get; set; }

        public string Email { get; set; }

        public string Apelido { get; set; }
 
    public List<Contato> RetornarTodos(){
        return repo.SelecionarTodos();
    }

        public Contato BuscarContato(int id) {
        return repo.BuscarContato(id);
        }

        public void IncluirContato (Contato contato){
            repo.IncluirContato(contato);
        }

        public void EditarContato(Contato contato)
        {
            repo.EditarContato(contato);
        }

        public void ExcluirContato(int id)
        {
            repo.ExcluirContado(id);
        }
    }
}