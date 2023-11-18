using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizer.Models;

[Table("Medicamentos")]
public class Medicamento
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Obrigatório informar o nome!")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "Obrigatório informar o princípio ativo!")]
    [Display(Name = "Princípio Ativo")]
    public string PrincipioAtivo { get; set; }
    
    [Required(ErrorMessage = "Obrigatório informar a classificação!")]
    [Display(Name = "Classificação")]
    public Classificacao Classificacao { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o fabricante!")]
    [Display(Name = "Fabricante")]
    public string Fabricante { get; set; }

    [Required(ErrorMessage = "Obrigatório informar a descrição!")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }
    
    [Required(ErrorMessage = "Obrigatório informar o tipo do medicamento!")]
    [Display(Name = "Tipo do Medicamento")]
    public TipoMedicamento Tipo { get; set; }
    
    [Required(ErrorMessage = "Obrigatório informar a forma da administração!")]
    [Display(Name = "Forma de Administração")]
    public FormaAdministracao Administracao { get; set; }
    
    [Required(ErrorMessage = "Obrigatório informar se tem retenção da receita!")]
    [Display(Name = "Retenção da Receita")]
    public bool RetencaoReceita { get; set; }

    public Medicamento()
    {
        Nome = string.Empty;
        PrincipioAtivo = string.Empty;
        Fabricante = string.Empty;
        Descricao = string.Empty;
    }
}

public enum TipoMedicamento
{
    Original,
    Similar,
    Generico
}
public enum Classificacao{
    Nenhuma,
    TarjaVermelha,
    TarjaPreta
}

public enum FormaAdministracao
{
    Injetaveis, 
    ParaInalacao, 
    Sublingual, 
    UsoBucal, 
    ViaVaginal, 
    ViaUretral, 
    ViaAuricular, 
    ViaNasal, 
    ViaOcular, 
    ViaOral, 
    ViaRetal, 
    ViaSubcutanea, 
    Viatopica, 
    ViaImplante, 
    Usotransdérmico
}