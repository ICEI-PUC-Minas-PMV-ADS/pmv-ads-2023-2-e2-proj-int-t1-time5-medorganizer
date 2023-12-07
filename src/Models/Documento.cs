using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedOrganizerE2.Models
{
    [Table("Documento")]
    public class Documento
    {
        [Key]
        public int Id { get; set; }

        // Atributos como TipoDocumento, DataEmissao, Arquivo, etc.
        public string TipoDocumento { get; set; }
        public DateTime DataEmissao { get; set; }
        public byte[] Arquivo { get; set; } // Ou string para um caminho de arquivo
    }
}