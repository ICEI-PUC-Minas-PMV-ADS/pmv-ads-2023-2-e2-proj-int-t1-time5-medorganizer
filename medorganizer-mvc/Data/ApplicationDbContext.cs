using MedOrganizer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedOrganizer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        public DbSet<Medicamento>? Medicamentos { get; set; }
        
        public DbSet<Clinica>? Clinicas { get; set; }

        public DbSet<Usuario>? Usuarios { get; set; }
        
        public DbSet<Medico>? Medicos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        {
            
        }

    }
}