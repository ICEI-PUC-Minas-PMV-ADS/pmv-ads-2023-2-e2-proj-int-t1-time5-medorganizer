using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizer.Models;

[Table(name:"Medicos")]
public class Medico
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Obrigatório informar o nome!")]
    [MaxLength(150, ErrorMessage = "O nome não pode ter mais do que 150 caracteres.")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "Obrigatório informar o CRM!")]
    [MaxLength(50, ErrorMessage = "O CRM não pode ter mais do que 50 caracteres.")]
    public string Crm { get; set; }
    
    [Required(ErrorMessage = "Celular é um atributo obrigatório")]
    [Phone(ErrorMessage = "O número de celular fornecido não é válido.")]
    public string Celular { get; set; }
    
    [Required(ErrorMessage = "Email é um atributo obrigatório")]
    [EmailAddress(ErrorMessage = "O endereço de email fornecido não é válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Valor da Consulta é um atributo obrigatório")]
    [Range(0, double.MaxValue, ErrorMessage = "O valor da consulta não pode ser negativo.")]
    [Display(Name = "Valor da Consulta")]
    public decimal ValorConsulta { get; set; }
    
    [Required(ErrorMessage = "Especialidade é um atributo obrigatório")]
    [MaxLength(100, ErrorMessage = "A especialidade não pode ter mais do que 100 caracteres.")]
    public string Especialidade { get; set; }

    [Required(ErrorMessage = "Anotações é um atributo obrigatório")]
    [MaxLength(500, ErrorMessage = "Anotações não podem ter mais do que 500 caracteres.")]
    [Display(Name = "Anotações")]
    public string Anotacoes { get; set; }

    public Medico()
    {
        Nome = string.Empty;
        Crm = string.Empty;
        Celular = string.Empty;
        Email = string.Empty;
        Especialidade = string.Empty;
        Anotacoes = string.Empty;
    }
}