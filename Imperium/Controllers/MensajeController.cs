using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imperium.Models;
using Microsoft.EntityFrameworkCore;

namespace Imperium.Controllers
{
    public class MensajeController : Controller
    {
        private readonly ImperiumContext _context;

        public MensajeController(ImperiumContext contexto)
        {
            _context = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Contactos.ToListAsync());
        }

        public async Task<IActionResult> Consulta_detalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var casa = await _context.Casas.FirstOrDefaultAsync(m => m.Idcasa == id);
            if (casa == null)
            {
                return NotFound();
            }
            return View(casa);
        }
    }
}
