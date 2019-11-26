using Floricultura2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floricultura2.Repositorio
{
    public class ChocolateRepositorio
    {
        //Declarando uma lista de chocolates
        private List<Chocolate> _chocolate;

        //injeção de dependência -- 
        public ChocolateRepositorio(List<Chocolate> chocolatesGuardados)
        {
            _chocolate = chocolatesGuardados;
        }
        //método listar chocolates 
        public List<Chocolate> Listar()
        {
            return _chocolate;
        }

        //o método abaixo vai à lista de flores e adiciona uma flor
        //aqui temos um método do objeto flor repositório
        public void Adicionar(Chocolate chocolates)
        {
            _chocolate.Add(chocolates);
        }

       

    }
}
