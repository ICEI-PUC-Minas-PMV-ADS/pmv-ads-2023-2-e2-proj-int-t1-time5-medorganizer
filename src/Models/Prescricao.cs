using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizerE2.Models
{

    [Table(name: "Prescricao")]
    public class Prescricao
    {
        [Key]
        public int Id { get; set; }

        // Chave estrangeira para ConsultaMedica
        [Required(ErrorMessage = "Obrigatório informar a Consulta Médica!")]
        public int ConsultaMedicaId { get; set; }
        public ConsultaMedica ConsultaMedica { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Medicamento")]
        public int MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Medico")]
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }

        // Atributos como Status, Vezes, Progresso, Frequência, Quantidade, etc.
        [Required]
        public StatusPrescricao Status { get; set; }
        public int Vezes { get; set; }
        public int Progresso { get; set; }
        public Frequencia Frequencia { get; set; }
        public int Quantidade { get; set; }
        public string Duracao { get; set; }
        public string InstrucoesAdicionais { get; set; }

        // Relação com Medicacao
        public ICollection<Medicacao> Medicacoes { get; set; }

    }

    public enum StatusPrescricao
    {
        Pendente,
        Administrando,
        Concluído

    }

    public enum Frequencia
    {
        Diária,
        Semanal,
        Quinzenal,
        Mensal
    }

    public enum Duracao
    {
        Sessenta_dias,
        Trinda_dias,
        Vinte_dias,
        Quinze_dias,
        Dez_dias,
        Cinco_dias,
        Tres_dias,
        Não_Definido,
        Uso_Contínuo,
        Quatro_Semanas
    }
}