using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizer.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é um atributo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Senha é um atributo obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Perfil é um atributo obrigatório")]
        public Perfil Perfil { get; set; }

        public Usuario()
        {
            Nome = string.Empty;
            Senha = string.Empty;
        }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
