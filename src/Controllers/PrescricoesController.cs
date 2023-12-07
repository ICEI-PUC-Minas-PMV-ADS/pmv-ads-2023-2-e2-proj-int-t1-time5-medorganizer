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
    public class PrescricoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrescricoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prescricoes
        public async Task<IActionResult> Index()
        {
              return _context.Prescricoes != null ? 
                          View(await _context.Prescricoes
                                .Include(x => x.Medico)
                                .Include(x => x.Medicamento)
                                .Include(x => x.ConsultaMedica).ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Prescricoes'  is null.");
        }

        // GET: Prescricoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Prescricoes == null)
            {
                return NotFound();
            }

            var prescricao = await _context.Prescricoes
                .Include(x => x.Medico)
                .Include(x => x.Medicamento)
                .Include(x => x.ConsultaMedica)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prescricao == null)
            {
                return NotFound();
            }

            return View(prescricao);
        }

        // GET: Prescricoes/Create
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

            // Obtém os medicamentos do banco de dados
            var medicamentos = _context.Medicamentos.Select(m => new
            {
                Id = m.Id,
                Nome = m.Nome
            }).ToList();
            // Cria uma SelectList
            ViewBag.Medicamentos = new SelectList(medicamentos, "Id", "Nome");

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

        // POST: Prescricoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ConsultaMedicaId,MedicamentoId,MedicoId,Status,Vezes,Progresso,Frequencia,Quantidade,Duracao,InstrucoesAdicionais")] Prescricao prescricao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prescricao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // Se o ModelState não for válido, retorne à view com os dados atuais
            ViewBag.Medicos = new SelectList(_context.Medicos, "Id", "Nome", prescricao.MedicoId);
            ViewBag.Medicamentos = new SelectList(_context.Medicamentos, "Id", "Nome", prescricao.MedicamentoId);
            ViewBag.Consultas = new SelectList(_context.Consultas, "Id", "Nome", prescricao.ConsultaMedicaId);
            return View(prescricao);
        }

        // GET: Prescricoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Prescricoes == null)
            {
                return NotFound();
            }

            var prescricao = await _context.Prescricoes.FindAsync(id);
            if (prescricao == null)
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

            // Obtém os medicamentos do banco de dados
            var medicamentos = _context.Medicamentos.Select(m => new
            {
                Id = m.Id,
                Nome = m.Nome
            }).ToList();
            // Cria uma SelectList
            ViewBag.Medicamentos = new SelectList(medicamentos, "Id", "Nome");

            // Obtém as consultas do banco de dados
            var consultas = _context.Consultas.Select(m => new
            {
                Id = m.Id,
                Nome = m.Nome
            }).ToList();
            // Cria uma SelectList
            ViewBag.Consultas = new SelectList(consultas, "Id", "Nome");

            return View(prescricao);
        }

        // POST: Prescricoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConsultaMedicaId,MedicamentoId,MedicoId,Status,Vezes,Progresso,Frequencia,Quantidade,Duracao,InstrucoesAdicionais")] Prescricao prescricao)
        {
            if (id != prescricao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prescricao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrescricaoExists(prescricao.Id))
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
            ViewBag.Medicos = new SelectList(_context.Medicos, "Id", "Nome", prescricao.MedicoId);
            ViewBag.Medicamentos = new SelectList(_context.Medicamentos, "Id", "Nome", prescricao.MedicamentoId);
            ViewBag.Consultas = new SelectList(_context.Consultas, "Id", "Nome", prescricao.ConsultaMedicaId);
            return View(prescricao);
        }

        // GET: Prescricoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Prescricoes == null)
            {
                return NotFound();
            }

            var prescricao = await _context.Prescricoes
                .Include(x => x.Medico)
                .Include(x => x.Medicamento)
                .Include(x => x.ConsultaMedica)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prescricao == null)
            {
                return NotFound();
            }

            return View(prescricao);
        }

        // POST: Prescricoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Prescricoes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Prescricoes'  is null.");
            }
            var prescricao = await _context.Prescricoes.FindAsync(id);
            if (prescricao != null)
            {
                _context.Prescricoes.Remove(prescricao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrescricaoExists(int id)
        {
          return (_context.Prescricoes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
