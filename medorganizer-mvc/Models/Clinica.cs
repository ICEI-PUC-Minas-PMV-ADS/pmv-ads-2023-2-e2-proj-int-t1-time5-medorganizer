using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizer.Models
{
    [Table("Clinica")]
    public class Clinica
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é um atributo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Telefone é um atributo obrigatório")]
        public string Telefone { get; set; }

        public string Celular { get; set; }

        [Required(ErrorMessage = "Email é um atributo obrigatório")]
        public string Email { get; set; }

        public string Url { get; set; }

        public string ChavePix { get; set; }

        [Required(ErrorMessage = "Endereço é um atributo obrigatório")]
        public string Endereco { get; set; }
    }
}
