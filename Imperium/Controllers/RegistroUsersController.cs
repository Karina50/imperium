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
    public class RegistroUsersController : Controller
    {
        private readonly ImperiumContext _context;

        public RegistroUsersController(ImperiumContext context)
        {
            _context = context;
        }

        // GET: RegistroUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroUsers.ToListAsync());
        }

        // GET: RegistroUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroUser = await _context.RegistroUsers
                .FirstOrDefaultAsync(m => m.Iduser == id);
            if (registroUser == null)
            {
                return NotFound();
            }

            return View(registroUser);
        }

        // GET: RegistroUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistroUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*IFormFile archivo, RegistroUser registroUser*/ [Bind("Iduser,Nombre,Correo,Telefono,Usuario,Contra,Rol,Pais,Estado,Localidad")] RegistroUser registroUser)
        {

            if (ModelState.IsValid)
            {
                //registroUser.Fotografia = SubirImagen("Imagenes", archivo);

                _context.Add(registroUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(registroUser);
        }

        //private string SubirImagen(string rutaCarpeta, IFormFile ArchivoSubir)
        //{
        //    string carpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", rutaCarpeta);

        //    string Nombrearchivo = Guid.NewGuid().ToString() + "_" + ArchivoSubir.FileName;

        //    string RutaArchivoUnico = Path.Combine(carpeta, Nombrearchivo);

        //    using (var InfoArchivo = new FileStream(RutaArchivoUnico, FileMode.Create))
        //        ArchivoSubir.CopyTo(InfoArchivo);

        //    return Nombrearchivo;
        //}

        // GET: RegistroUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroUser = await _context.RegistroUsers.FindAsync(id);
            if (registroUser == null)
            {
                return NotFound();
            }
            return View(registroUser);
        }

        // POST: RegistroUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Iduser,Nombre,Correo,Telefono,Usuario,Contra,Rol,Pais,Estado,Localidad,Fotografia")] RegistroUser registroUser)
        {
            if (id != registroUser.Iduser)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroUserExists(registroUser.Iduser))
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
            return View(registroUser);
        }

        // GET: RegistroUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroUser = await _context.RegistroUsers
                .FirstOrDefaultAsync(m => m.Iduser == id);
            if (registroUser == null)
            {
                return NotFound();
            }

            return View(registroUser);
        }

        // POST: RegistroUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroUser = await _context.RegistroUsers.FindAsync(id);
            _context.RegistroUsers.Remove(registroUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroUserExists(int id)
        {
            return _context.RegistroUsers.Any(e => e.Iduser == id);
        }
    }
}
