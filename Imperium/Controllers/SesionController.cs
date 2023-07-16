using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Imperium.Controllers;
using Imperium.Models;
using Microsoft.AspNetCore.Http;

namespace Imperium.Controllers
{
    public class SesionController : Controller
    {
        private readonly ImperiumContext _context;

        public SesionController (ImperiumContext contexto)
        {
            _context = contexto;
        }

        public RegistroUser Cuenta { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Onpost(string cor, string con)
        {
            //Comprobar que existe en la BD

            Cuenta = _context.RegistroUsers.Where(p => p.Correo == cor && p.Contra == con).FirstOrDefault<RegistroUser>();

            if(Cuenta != null)
            {
                HttpContext.Session.SetString("Sesion1", Cuenta.Usuario);

                return RedirectToAction("Index", "Catalogo");

            }

            return RedirectToAction("Index", "Sesion");


        }

        public ActionResult LogOut()
        {
            HttpContext.Session.Remove("Sesion1");
            return RedirectToAction("Index", "Sesion");
        }

    }
}
