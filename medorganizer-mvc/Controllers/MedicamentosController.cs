using MedOrganizer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedOrganizer.Controllers;

public class MedicamentosController : Controller
{
    private readonly ApplicationDbContext _context;

    public MedicamentosController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var dados = await _context.Medicamentos.ToListAsync();
        return View(dados);
    }
    
    
}