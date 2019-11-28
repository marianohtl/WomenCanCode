using Floricultura2.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floricultura2.Controllers
{
//    [Route("Chocolates/{action}")]
//    [Route("Chocolate/{action}")]
    public class ChocolateController : Controller
    {


        private ChocolateRepositorio _repositorio;

        public ChocolateController(List<Chocolate> chocolates)
        {
            _repositorio = new ChocolateRepositorio(chocolates);
        }

        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Index()
        //{
        //    var flores = _repositorio.Listar();
        //    return View(flores);
        //}

    }
}
