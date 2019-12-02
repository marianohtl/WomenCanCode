using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaMedia.Models;

namespace SistemaMedia.Controllers
{
    
    public class AlunoController : Controller
    {
        Aluno aluno;

        public AlunoController()
        {
            aluno = new Aluno();
        }

        public ActionResult Index()
        {
            return View(aluno.RetornarAlunos());
        }

  

        // POST: api/Aluno
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Aluno/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
