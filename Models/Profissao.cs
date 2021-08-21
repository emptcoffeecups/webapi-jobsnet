using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aec_webapi_ef.Models
{
    [Table("profissoes")]
    public class Profissao
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required]
        public string Nome { get; set; }

        [Column("descricao", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required]
        public string Descricao { get; set; }

    }
}