using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using site3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // return new ContentResult { Content = "Olá mundo!", ContentType = "Text/json" };

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email == "hzpck17@gmail.com" && usuario.Senha == "123456")
                {
                    //   HttpContext.Session.SetString("Login", "true");
                    //  HttpContext.Session.SetInt32("UserID", 32);

                    //string login = HttpContext.Session.GetString("Login");

                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Mesagem = "Os dados informados são inválidos";
                    return View();
                }
            }
            else
            {
            return View();
            }
            
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}
