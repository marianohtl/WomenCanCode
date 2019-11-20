using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EscolaProgamacao.Models;

namespace EscolaProgamacao.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        //definindo rotas 
        [Route("materias")]
        public IActionResult Materias() {

            List<Materia> materias = new List<Materia>();
            materias.Add(new Materia()
            {
                Nome = "React",
                Descricao = "Desenvolvimento Web"
            });

            materias.Add(new Materia()
            {
                Nome = "C#"
            });

            return View("Views/Home/materias/Materias.cshtml", materias);
        }
        //acima mostrando telas 
        //https://localhost:44309/home/materias
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
