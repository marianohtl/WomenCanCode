using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Floricultura2.Models;
using Floricultura2.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Floricultura2.Controllers
{
    public class FloresController : Controller
    {
        private FlorRepositorio _repositorio;

        public FloresController(List<Flor> flores)
        {
            _repositorio = new FlorRepositorio(flores);
        }
        public IActionResult Index()
        {
            var flores = _repositorio.Listar();
            return View(flores);
        }


        //fazendo com que a nossa florcontroller nos retorne uma view
        ///sem este datanotation nada funciona 
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Flor flor)
        {
            _repositorio.Adicionar(flor);
            return View();
        }
    }
}