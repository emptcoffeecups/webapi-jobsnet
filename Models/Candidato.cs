using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace aec_webapi_ef.Models
{
    [Table ("candidatos")]
    public class Candidato
    {
        [Key]
        [Column("id", Order = 1)]
        public int Id { get; set; }

        [Column("cpf", Order = 2)]
        [MaxLength(14)]
        [Required]
        public string Cpf { get; set; }

        [Column("nome", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required]
        public string Nome { get; set; }

        [Column("nascimento", TypeName = "nvarchar")]
        [MaxLength(10)]
        [Required]
        public string Nascimento { get; set; }

        [Column("email", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }

        [Column("telefone", TypeName = "nvarchar")]
        [MaxLength(15)]
        [Required]
        public string Telefone { get; set; }

        [Column("profissaoId")]
        [ForeignKey("ProfissaoId")]
        [Required]
        public int ProfissaoId { get; set; } 

        [JsonIgnore] //Ignorar visualização da propriedade no Json
        public Profissao Profissao { get; set; }

        [Column("logradouro", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required]
        public string Logradouro { get; set; }

        [Column("complemento", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required]
        public string Complemento { get; set; }

        [Column("numero", TypeName = "nvarchar")]
        [MaxLength(5)]
        [Required]
        public string Numero { get; set; }

        [Column("bairro", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required]
        public string Bairro { get; set; }

        [Column("cidade", TypeName = "nvarchar")]
        [MaxLength(60)]
        [Required]
        public string Cidade { get; set; }

        [Column("cep", TypeName = "nvarchar")]
        [MaxLength(9)]
        [Required]
        public string Cep { get; set; }

        [Column("estado", TypeName = "nchar")]
        [MaxLength(2)]
        [Required]
        public string Estado { get; set; }

    }
}