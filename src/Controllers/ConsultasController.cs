using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MedOrganizerE2.Data;
using MedOrganizerE2.Models;
using Microsoft.AspNetCore.Authorization;

namespace MedOrganizerE2.Controllers
{
    [Authorize]
    public class ConsultasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConsultasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Consultas
        public async Task<IActionResult> Index()
        {
              return _context.Consultas != null ? 
                          View(await _context.Consultas
                                .Include(x => x.Medico)
                                .Include(x => x.Clinica).ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Consultas'  is null.");
        }

        // GET: Consultas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Consultas == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(x => x.Medico)
                .Include(x => x.Clinica)
                .Include(x => x.ExamesMedicos)
                .Include(x => x.Prescricoes)
                    .ThenInclude(p => p.Medicamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // GET: Consultas/Create
        public IActionResult Create()
        {
            // Obtém os médicos do banco de dados
            var medicos = _context.Medicos.Select(m => new
            {
                Id = m.Id,
                Nome = m.Nome
            }).ToList();
            // Cria uma SelectList
            ViewBag.Medicos = new SelectList(medicos, "Id", "Nome");

            // Obtém os clinicas do banco de dados
            var clinicas = _context.Clinicas.Select(m => new
            {
                Id = m.Id,
                Nome = m.Nome
            }).ToList();
            // Cria uma SelectList
            ViewBag.Clinicas = new SelectList(clinicas, "Id", "Nome");

            return View();
        }

        // POST: Consultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataHora,Status,MedicoId,ClinicaId,Anotacoes")] ConsultaMedica consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // Se o ModelState não for válido, retorne à view com os dados atuais
            ViewBag.Medicos = new SelectList(_context.Medicos, "Id", "Nome", consulta.MedicoId);
            ViewBag.Clinicas = new SelectList(_context.Clinicas, "Id", "Nome", consulta.ClinicaId);
            return View(consulta);
        }

        // GET: Consultas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Consultas == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return View(consulta);
        }

        // POST: Consultas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataHora,Status,MedicoId,ClinicaId,Anotacoes")] ConsultaMedica consulta)
        {
            if (id != consulta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaMedicaExists(consulta.Id))
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
            ViewBag.Medicos = new SelectList(_context.Medicos, "Id", "Nome", consulta.MedicoId);
            ViewBag.Clinicas = new SelectList(_context.Clinicas, "Id", "Nome", consulta.ClinicaId);
            return View(consulta);
        }

        // GET: Consultas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Consultas == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(x => x.Medico)
                .Include(x => x.Clinica)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // POST: Consultas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Consultas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Consultas'  is null.");
            }
            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta != null)
            {
                _context.Consultas.Remove(consulta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultaMedicaExists(int id)
        {
          return (_context.Consultas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
