using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    public class ContatoController : Controller
    {

        List<Contato> Contatos;
        // GET: Contato

        public ContatoController() {
            Contatos = new List<Contato>();
            Contatos.Add(new Contato("Litah", "11 95155-4122", "litah@gmail.com"));
        }
        public ActionResult Index()
        {
            return View(Contatos);
        }

        // GET: Contato/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contato/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contato/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contato/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contato/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contato/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}