using Agenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Repositorio
{
    public class ContatoRepositorio
    {
        List<Contato> Contatos;
        // GET: Contato

        private void CriarDados()
        {
            Contatos = new List<Contato>();
            Contatos.Add(new Contato(1,"Litah", "11 95155-4122", "litah@gmail.com"));
        }

        public ContatoRepositorio()
        {
            CriarDados();
        }

        public List<Contato> SelecionarTodos()
        {
            return Contatos.OrderBy(t => t.Nome).ToList();
        }
    
        //public Contato BuscarContato(int id)
        //{
        //    return Contatos.FirstOrDefault(t => t.Id == id);
        //}
        //public void IncluirContato(Contato contato) {
        //    Contatos.Add(contato);
        //}

        //public void EditarContato (Contato contato){
        //    var meuContato = BuscarContato(contato.Id);
        //    //o indexof retorna a posição em que o objeto está
        //    int indice = Contatos.IndexOf(meuContato);
        //    Contatos[indice] = contato;
        //}

        //public void ExcluirContado(int id) {
        //    var meuContato = BuscarContato(id);
        //    Contatos.Remove(meuContato);
        //}
    }
}


