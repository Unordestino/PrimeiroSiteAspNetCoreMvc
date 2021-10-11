using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using site3.Models;
using site3.Library.Mail;

namespace site3.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Contato = new Contato();
            return View();
        }

        public IActionResult recebercontato([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                //string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Menssagem {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                //  return new ContentResult() { Content = conteudo };

                ViewBag.Contato = new Contato();
                EnviarEmail.EnviarMensagemContato(contato);
                ViewBag.Mensagem = "Mensagem enviada com sucesso";
                return View("Index");
            }
            else
            {
                ViewBag.Contato = contato;
                return View("Index");
            }
          
        }

        // obter dados manualmente

        //public IActionResult recebercontato()
        //{
        //    Contato contato = new Contato();
        //    contato.Nome = Request.Form["Nome"];
        //    contato.Email = Request.Form["Email"];
        //    contato.Assunto = Request.Form["Assunto"];
        //    contato.Mensagem = Request.Form["Mensagem"];
        //    string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Menssagem {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
        //    return new ContentResult() { Content = conteudo };

        //}

    }
}
