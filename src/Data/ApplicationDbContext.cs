using MedOrganizerE2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedOrganizerE2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Medicamento>? Medicamentos { get; set; }

    public DbSet<Clinica>? Clinicas { get; set; }

    public DbSet<Medico>? Medicos { get; set; }

    public DbSet<ExameMedico>? Exames { get; set; }

    public DbSet<ConsultaMedica>? Consultas { get; set; }

    public DbSet<Medicacao>? Medicacoes { get; set; }

    public DbSet<Prescricao>? Prescricoes { get; set; }

    public DbSet<Documento>? Documentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Suas configurações personalizadas vão aqui

        // Exemplo: precisão total de 18 e 2 dígitos decimais
        modelBuilder.Entity<Medico>()
        .Property(m => m.ValorConsulta)
        .HasPrecision(18, 2);
        
        modelBuilder.Entity<ExameMedico>()
        .HasOne(e => e.ConsultaMedica)
        .WithMany(c => c.ExamesMedicos) // Assegure-se de que isso corresponde à coleção na classe ConsultaMedica
        .HasForeignKey(e => e.ConsultaMedicaId)
        .OnDelete(DeleteBehavior.NoAction); // Alterar para NoAction ou outra opção adequada

        modelBuilder.Entity<Prescricao>()
        .HasOne(e => e.ConsultaMedica)
        .WithMany(c => c.Prescricoes) // Assegure-se de que isso corresponde à coleção na classe ConsultaMedica
        .HasForeignKey(e => e.ConsultaMedicaId)
        .OnDelete(DeleteBehavior.NoAction); // Alterar para NoAction ou outra opção adequada

        modelBuilder.Entity<Medicacao>()
        .HasOne(m => m.Prescricao)
        .WithMany(p => p.Medicacoes) // Assumindo que Prescricao tem uma coleção de Medicacoes
        .HasForeignKey(m => m.PrescricaoId)
        .OnDelete(DeleteBehavior.NoAction); // Alterar para NoAction
        // Por exemplo, configurações de filtros globais, tipos de colunas, etc.
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}

