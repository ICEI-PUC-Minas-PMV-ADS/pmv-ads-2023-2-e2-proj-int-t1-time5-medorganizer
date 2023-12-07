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
    public class MedicacoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicacoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Medicacoes
        public async Task<IActionResult> Index()
        {
              return _context.Medicacoes != null ? 
                          View(await _context.Medicacoes
                                .Include(x => x.Medico)
                                .Include(x => x.Clinica)
                                .Include(x => x.Prescricao).ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Medicacoes'  is null.");
        }

        // GET: Medicacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Medicacoes == null)
            {
                return NotFound();
            }

            var medicacao = await _context.Medicacoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicacao == null)
            {
                return NotFound();
            }

            return View(medicacao);
        }

        // GET: Medicacoes/Create
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
            
            // Obtém as Prescricoes do banco de dados
            var prescricoes = _context.Prescricoes.Select(m => new
            {
                Id = m.Id,
                Nome = m.Medicamento.Nome
            }).ToList();
            // Cria uma SelectList
            ViewBag.Prescricoes = new SelectList(prescricoes, "Id", "Nome");
            return View();
        }

        // POST: Medicacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataHora,Status,PrescricaoId,MedicoId,ClinicaId,Anotacoes")] Medicacao medicacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // Se o ModelState não for válido, retorne à view com os dados atuais
            ViewBag.Medicos = new SelectList(_context.Medicos, "Id", "Nome", medicacao.MedicoId);
            ViewBag.Clinicas = new SelectList(_context.Clinicas, "Id", "Nome", medicacao.ClinicaId);
            ViewBag.Prescricoes = new SelectList(_context.Prescricoes, "Id", "Nome", medicacao.PrescricaoId);
            return View(medicacao);
        }

        // GET: Medicacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Medicacoes == null)
            {
                return NotFound();
            }

            var medicacao = await _context.Medicacoes.FindAsync(id);
            if (medicacao == null)
            {
                return NotFound();
            }
            return View(medicacao);
        }

        // POST: Medicacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataHora,Status,PrescricaoId,MedicoId,ClinicaId,Anotacoes")] Medicacao medicacao)
        {
            if (id != medicacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicacaoExists(medicacao.Id))
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
            return View(medicacao);
        }

        // GET: Medicacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Medicacoes == null)
            {
                return NotFound();
            }

            var medicacao = await _context.Medicacoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicacao == null)
            {
                return NotFound();
            }

            return View(medicacao);
        }

        // POST: Medicacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Medicacoes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Medicacoes'  is null.");
            }
            var medicacao = await _context.Medicacoes.FindAsync(id);
            if (medicacao != null)
            {
                _context.Medicacoes.Remove(medicacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicacaoExists(int id)
        {
          return (_context.Medicacoes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
