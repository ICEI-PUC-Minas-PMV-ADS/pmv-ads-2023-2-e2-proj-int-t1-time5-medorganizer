using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MedOrganizerE2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MedOrganizerE2.ViewModels;

namespace MedOrganizerE2.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly Data.ApplicationDbContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, Data.ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> IndexAsync()
    {
        var consultas = await _context.Consultas
            .Include(x => x.Medico)
            .Include(x => x.Clinica).ToListAsync();
        var exames = await _context.Exames
            .Include(x => x.Medico)
            .Include(x => x.Clinica).ToListAsync();

        var model = new HomeIndexViewModel
        {
            ConsultasMedicas = consultas,
            ExamesMedicos = exames
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

