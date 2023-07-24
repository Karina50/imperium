using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Imperium.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Imperium.Controllers
{
    public class CasasController : Controller
    {
        private readonly ImperiumContext _context;

        public CasasController(ImperiumContext context)
        {
            _context = context;
        }

        // GET: Casas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Casas.ToListAsync());
        }

        // GET: Casas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casa = await _context.Casas
                .FirstOrDefaultAsync(m => m.Idcasa == id);
            if (casa == null)
            {
                return NotFound();
            }

            return View(casa);
        }

        // GET: Casas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Casas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile archivo, Casa casa)
        {
            if (ModelState.IsValid)
            {

                casa.Imagen = SubirImagen("Imagenes", archivo);

                _context.Add(casa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(casa);
        }

        private string SubirImagen(string rutaCarpeta, IFormFile ArchivoSubir)
        {
            string carpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", rutaCarpeta);

            string Nombrearchivo = Guid.NewGuid().ToString() + "_" + ArchivoSubir.FileName;

            string RutaArchivoUnico = Path.Combine(carpeta, Nombrearchivo);

            using (var InfoArchivo = new FileStream(RutaArchivoUnico, FileMode.Create)) 
            ArchivoSubir.CopyTo(InfoArchivo);

            return Nombrearchivo;
        }

        // GET: Casas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casa = await _context.Casas.FindAsync(id);
            if (casa == null)
            {
                return NotFound();
            }
            return View(casa);
        }

        // POST: Casas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idcasa,Nombre,Precio,DescripcionPropiedad,RentaOventa,TipoVivienda,Superficie,Caracteristicas,Coordenadas,Imagen")] Casa casa, IFormFile archivo)
        {
            if (id != casa.Idcasa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (archivo != null)
                    {
                        // Eliminar la imagen anterior si existe
                        if (!string.IsNullOrEmpty(casa.Imagen))
                        {
                            string carpetaAnterior = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Imagenes");
                            string rutaImagenAnterior = Path.Combine(carpetaAnterior, casa.Imagen);

                            if (System.IO.File.Exists(rutaImagenAnterior))
                            {
                                System.IO.File.Delete(rutaImagenAnterior);
                            }
                        }

                        // Subir la nueva imagen
                        casa.Imagen = SubirImagen("Imagenes", archivo);
                    }

                    _context.Update(casa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasaExists(casa.Idcasa))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(casa);
        }

        private string SubirImagen2(string rutaCarpeta, IFormFile ArchivoSubir)
        {
            string carpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", rutaCarpeta);

            string Nombrearchivo = Guid.NewGuid().ToString() + "_" + ArchivoSubir.FileName;

            string RutaArchivoUnico = Path.Combine(carpeta, Nombrearchivo);

            using (var InfoArchivo = new FileStream(RutaArchivoUnico, FileMode.Create))
                ArchivoSubir.CopyTo(InfoArchivo);

            return Nombrearchivo;
        }

        // GET: Casas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casa = await _context.Casas
                .FirstOrDefaultAsync(m => m.Idcasa == id);
            if (casa == null)
            {
                return NotFound();
            }

            return View(casa);
        }

        // POST: Casas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var casa = await _context.Casas.FindAsync(id);
            _context.Casas.Remove(casa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CasaExists(int id)
        {
            return _context.Casas.Any(e => e.Idcasa == id);
        }
    }
}
