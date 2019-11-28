using Floricultura2.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//    [Route("Chocolates/{action}")]
//    [Route("Chocolate/{action}")]

namespace Floricultura2.Controllers
{
    public class ChocolatesController : Controller
    {

        private ChocolateRepositorio _repositorio;

        //ref. a injestão de dependência (colocar na startap isto please) services.AddSingleton<List<Chocolate>>();
        //-- Método Construtor
        public ChocolatesController(List<Chocolate> chocolates)
        {
            _repositorio = new ChocolateRepositorio(chocolates);
        }

        // 1º abertura da View com retorno do objeto com dados
        public IActionResult Index()
        {
            var chocolates = _repositorio.Listar();
            return View(chocolates);
        }


        [HttpPost]
        public IActionResult Criar(Chocolate chocolate)
        {
            _repositorio.Adicionar(chocolate);
            return View(nameof(Index));
        }


    




    }

}



