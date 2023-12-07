using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizerE2.Models
{
    [Table("Exames")]
    public class ExameMedico : Evento
    {
        // Chave estrangeira para ConsultaMedica
        [Required(ErrorMessage = "Obrigatório informar a Consulta Médica!")]
        public int ConsultaMedicaId { get; set; }
        
        public ConsultaMedica ConsultaMedica { get; set; }
    }
}