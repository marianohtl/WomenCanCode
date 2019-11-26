using Floricultura2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floricultura2.Repositorio
{
    public class FlorRepositorio
    {
    

        //lista de floress com acesso apenas a classe lissta de flores
        // é comum e recomendado que, quando usamos algo priva, usamos o _ (underline e primeira palavra minúscula)
        private List<Flor> _flores;

        //Não estamos criando uma nova lista, estaremos usando uma lista criada no startup
   //


        //injeção de dependência

        public FlorRepositorio(List<Flor> floresGuardadas){
            _flores = floresGuardadas;
        }

        //o método abaixo vai à lista de flores e adiciona uma flor
        //aqui temos um método do objeto flor repositório
        public void Adicionar(Flor flor)
        {
            _flores.Add(flor);
        }

        //este método vai listar e retornar a lista de flores 
        public List<Flor> Listar()
        {
            return _flores;
        }


        public Flor Obter (string id)
        {
            //quando digitar where você vai precisar dar um cntrl
            //para adicionar o usin system linq
            var flor = _flores.Where(x => x.Id.ToString() == id).FirstOrDefault();
            return flor;
        }


    }
}
