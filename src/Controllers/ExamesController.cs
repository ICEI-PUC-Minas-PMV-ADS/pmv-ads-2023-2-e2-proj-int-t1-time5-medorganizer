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
    public class ExamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Exames
        public async Task<IActionResult> Index()
        {
              return _context.Exames != null ? 
                          View(await _context.Exames
                                .Include(x => x.Medico)
                                .Include(x => x.Clinica)
                                .Include(x => x.ConsultaMedica).ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Exames'  is null.");
        }

        // GET: Exames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Exames == null)
            {
                return NotFound();
            }

            var exame = await _context.Exames
                .Include(x => x.Medico)
                .Include(x => x.Clinica)
                .Include(x => x.ConsultaMedica)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exame == null)
            {
                return NotFound();
            }

            return View(exame);
        }

        // GET: Exames/Create
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

            // Obtém as consultas do banco de dados
            var consultas = _context.Consultas.Select(m => new
            {
                Id = m.Id,
                Nome = m.Nome
            }).ToList();
            // Cria uma SelectList
            ViewBag.Consultas = new SelectList(consultas, "Id", "Nome");
            return View();
        }

        // POST: Exames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataHora,Status,MedicoId,ClinicaId,ConsultaMedicaId,Anotacoes")] ExameMedico exame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // Se o ModelState não for válido, retorne à view com os dados atuais
            ViewBag.Medicos = new SelectList(_context.Medicos, "Id", "Nome", exame.MedicoId);
            ViewBag.Clinicas = new SelectList(_context.Clinicas, "Id", "Nome", exame.ClinicaId);
            ViewBag.Consultas = new SelectList(_context.Consultas, "Id", "Nome", exame.ConsultaMedicaId);
            return View(exame);
        }

        // GET: Exames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Exames == null)
            {
                return NotFound();
            }

            var exame = await _context.Exames.FindAsync(id);
            if (exame == null)
            {
                return NotFound();
            }
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

            // Obtém as consultas do banco de dados
            var consultas = _context.Consultas.Select(m => new
            {
                Id = m.Id,
                Nome = m.Nome
            }).ToList();
            // Cria uma SelectList
            ViewBag.Consultas = new SelectList(consultas, "Id", "Nome");
            return View(exame);
        }

        // POST: Exames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataHora,Status,MedicoId,ClinicaId,ConsultaMedicaId,Anotacoes")] ExameMedico exame)
        {
            if (id != exame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExameMedicoExists(exame.Id))
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
            ViewBag.Medicos = new SelectList(_context.Medicos, "Id", "Nome", exame.MedicoId);
            ViewBag.Clinicas = new SelectList(_context.Clinicas, "Id", "Nome", exame.ClinicaId);
            ViewBag.Consultas = new SelectList(_context.Consultas, "Id", "Nome", exame.ConsultaMedicaId);
            return View(exame);
        }

        // GET: Exames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Exames == null)
            {
                return NotFound();
            }

            var exame = await _context.Exames
                .Include(x => x.Medico)
                .Include(x => x.Clinica)
                .Include(x => x.ConsultaMedica)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exame == null)
            {
                return NotFound();
            }

            return View(exame);
        }

        // POST: Exames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Exames == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Exames'  is null.");
            }
            var exame = await _context.Exames.FindAsync(id);
            if (exame != null)
            {
                _context.Exames.Remove(exame);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExameMedicoExists(int id)
        {
          return (_context.Exames?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
