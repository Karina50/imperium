using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imperium.Models;
using Microsoft.EntityFrameworkCore;

namespace Imperium.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ImperiumContext _context;

        public CatalogoController(ImperiumContext contexto)
        {
            _context = contexto;
        }

        public async Task< IActionResult> Index()
        {
            return View(await _context.Casas.ToListAsync());
        }

        public async Task<IActionResult> Consulta_detalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var casa = await _context.Casas.FirstOrDefaultAsync(m => m.Idcasa == id);
            if(casa == null)
            {
                return NotFound();
            }
            return View(casa);
        }
    }
}
