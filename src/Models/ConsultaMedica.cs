using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizerE2.Models
{
    [Table("Consultas")]
    public class ConsultaMedica : Evento
    {

        // Relação com ExameMedico
        public ICollection<ExameMedico> ExamesMedicos { get; set; }

        // Relação com Prescricao
        public ICollection<Prescricao> Prescricoes { get; set; }

        public override string ToString()
        {
            return $"{Nome}: {DataHora}";
        }
    }
}