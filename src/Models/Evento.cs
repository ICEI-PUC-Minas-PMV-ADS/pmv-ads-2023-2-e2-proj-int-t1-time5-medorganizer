using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizerE2.Models
{
    public abstract class Evento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Data e Hora!")]
        public DateTime DataHora { get; set; }

        [Required(ErrorMessage = "Obrigatório nomear o evento!")]
        public string Nome { get; set; }
        public string Anotacoes { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Status!")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Clinica!")]
        public int ClinicaId { get; set; } // ID da clinica selecionada
        public Clinica Clinica { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Medico!")]
        public int MedicoId { get; set; } // ID do médico selecionado
        public Medico Medico { get; set; }


        // [Required]
        // public int UsuarioId { get; set; }
        // public Usuario Usuario { get; set; }

        // Outros atributos comuns a todos os eventos

        public Evento()
        {
            Nome = string.Empty;
            Anotacoes = string.Empty;
            Status = Status.Pendente;
        }

    }

    public enum Status
    {
        Pendente,
        Confirmado,
        Concluído
    }
}