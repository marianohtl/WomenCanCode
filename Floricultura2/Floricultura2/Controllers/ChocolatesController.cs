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
        public IActionResult Criar(Cho flor)
        {
            _repositorio.Adicionar(flor);
            return RedirectToAction(nameof(Index));
        }




    }

}



