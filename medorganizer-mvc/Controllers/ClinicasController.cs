using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MedOrganizer.Data;
using MedOrganizer.Models;
using Microsoft.AspNetCore.Authorization;

namespace MedOrganizer.Controllers
{
    [Authorize]
    public class ClinicasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClinicasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clinicas
        public async Task<IActionResult> Index()
        {
              return _context.Clinicas != null ? 
                          View(await _context.Clinicas.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Clinicas'  is null.");
        }

        // GET: Clinicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Clinicas == null)
            {
                return NotFound();
            }

            var clinica = await _context.Clinicas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clinica == null)
            {
                return NotFound();
            }

            return View(clinica);
        }

        // GET: Clinicas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clinicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Telefone,Celular,Email,Url,ChavePix,Endereco")] Clinica clinica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clinica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clinica);
        }

        // GET: Clinicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Clinicas == null)
            {
                return NotFound();
            }

            var clinica = await _context.Clinicas.FindAsync(id);
            if (clinica == null)
            {
                return NotFound();
            }
            return View(clinica);
        }

        // POST: Clinicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Telefone,Celular,Email,Url,ChavePix,Endereco")] Clinica clinica)
        {
            if (id != clinica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clinica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClinicaExists(clinica.Id))
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
            return View(clinica);
        }

        // GET: Clinicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Clinicas == null)
            {
                return NotFound();
            }

            var clinica = await _context.Clinicas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clinica == null)
            {
                return NotFound();
            }

            return View(clinica);
        }

        // POST: Clinicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Clinicas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Clinicas'  is null.");
            }
            var clinica = await _context.Clinicas.FindAsync(id);
            if (clinica != null)
            {
                _context.Clinicas.Remove(clinica);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClinicaExists(int id)
        {
          return (_context.Clinicas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
