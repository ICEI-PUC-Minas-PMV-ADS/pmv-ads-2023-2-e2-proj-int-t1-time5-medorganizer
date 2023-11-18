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

        [Required(ErrorMessage = "Celular é um atributo obrigatório")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Email é um atributo obrigatório")]
        [EmailAddress(ErrorMessage = "O endereço de email fornecido não é válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Url é um atributo obrigatório")]
        public string Url { get; set; }

        [Required(ErrorMessage = "ChavePix é um atributo obrigatório")]
        public string ChavePix { get; set; }

        [Required(ErrorMessage = "Endereço é um atributo obrigatório")]
        public string Endereco { get; set; }

        public Clinica()
        {
            Nome = string.Empty;
            Telefone = string.Empty;
            Celular = string.Empty;
            Email = string.Empty;
            Url = string.Empty;
            ChavePix = string.Empty;
            Endereco = string.Empty;
        }
    }
}
