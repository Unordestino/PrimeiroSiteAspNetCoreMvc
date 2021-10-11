using Microsoft.AspNetCore.Mvc;
using site3.DataBase;
using site3.Library.Filters;
using site3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace site3.Controllers
{
    [Login]
    public class PalavraController : Controller
    {
       
            List<Nivel> niveis = new List<Nivel>();
        private DataBaseContext _db;

        public PalavraController(DataBaseContext db)
        {
            _db = db;

            niveis.Add(new Nivel() { Id = 1, Nome =  "Fácil" });
            niveis.Add(new Nivel() { Id = 2, Nome =  "Médio" });
            niveis.Add(new Nivel() { Id = 3, Nome =  "Difícil" });

        }


        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;

            var palavras = _db.Palavras.ToList();
            var resultadoPaginado = palavras.ToPagedList(pageNumber, 5);
            return View(resultadoPaginado);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.Nivel = niveis;
            return View(new Palavra());
        }
        [HttpPost]
        public ActionResult Cadastrar([FromForm] Palavra palavra)
        {
            ViewBag.Nivel = niveis;

            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);
                _db.SaveChanges();

                TempData["Mensagem"] = "A palavra " + palavra.Nome +  " foi cadastrada com sucesso!";
                return RedirectToAction("Index");
            }

            return View(palavra);
        }

        [HttpGet]
        public ActionResult Atualizar(int Id)
        {
            ViewBag.Nivel = niveis;
            Palavra palavra = _db.Palavras.Find(Id);
            return View("Cadastrar", palavra);
        }
        [HttpPost]
        public ActionResult Atualizar([FromForm] Palavra palavra)
        {
            ViewBag.Nivel = niveis;
            if (ModelState.IsValid)
            {
                _db.Palavras.Update(palavra);
                _db.SaveChanges();

                TempData["Mensagem"] = "A palavra " + palavra.Nome + " foi atualizada com sucesso!";

                return RedirectToAction("Index");
            }
            return View("Cadastrar", palavra);
        }
        [HttpGet]
        public IActionResult Excluir(int Id)
        {

            Palavra palavra = _db.Palavras.Find(Id);
            _db.Palavras.Remove(palavra);
            _db.SaveChanges();
            TempData["Mensagem"] = "A palavra " + palavra.Nome + " foi deletada com sucesso!";
            return RedirectToAction("Index");
        }

    }
}
