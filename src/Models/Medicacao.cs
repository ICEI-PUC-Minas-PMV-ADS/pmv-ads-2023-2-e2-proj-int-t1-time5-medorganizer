using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizerE2.Models
{
    [Table("Medicacoes")]
    public class Medicacao : Evento
    {
        // Chave estrangeira para Prescricao
        public int PrescricaoId { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a Prescrição!")]
        public Prescricao Prescricao { get; set; }
        
    }
}