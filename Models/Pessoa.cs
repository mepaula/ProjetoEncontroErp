using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEncontro.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("Id_Pessoa")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PessoaNome")]
        [Display(Name = "Nome da Pessoa")]
        public string PessoaNome { get; set; } = string.Empty;

        [Column("PessoaRoupa")]
        [Display(Name = "Roupa da Pessoa")]
        public string PessoaRoupa { get; set; } = string.Empty;

        [Column("PessoaCor")]
        [Display(Name = "Cor da Pessoa")]
        public string PessoaCor { get; set; } = string.Empty;

        [Column("PessoaSexo")]
        [Display(Name = "Sexo da Pessoa")]
        public string PessoaSexo { get; set; } = string.Empty;

        [Column("PessoaObservacao")]
        [Display(Name ="Mais Observação")]
        public string PessoaObservacao { get; set; } = string.Empty;

        [Column("PessoaLocoalDesaparecimento")]
        [Display(Name = "Local do Desaparecimento")]
        public string PessoaLocoalDesaparecimento { get; set; } = string.Empty;

        [Column("PessoaDtDesaparecimento")]
        [Display(Name = "Data de Desaparecimento")]
        public DateTime PessoaDtDesaparecimento { get; set; } = DateTime.MinValue;

        [Column("PessoaFoto")]
        [Display(Name = "Foto da Pessoa")]
        public string PessoaFoto { get; set; } = string.Empty;

        [Column("PessoaDtEncontro")]
        [Display(Name = "Data de Encontro")]
        public DateTime? PessoaDtEncontro { get; set; } 

        [Column("PessoaStatus")]
        [Display(Name = "Status da Pessoa")]
        public byte PessoaStatus { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario{ get; set; }
       

    }
}
