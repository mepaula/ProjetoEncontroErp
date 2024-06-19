using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEncontro.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("Id_Observacoes")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("ObservacoesDescricao")]
        [Display(Name = "Descrição")]
        public string OnservacoesDescricao { get; set; } = string.Empty;

        [Column("ObservacoesLocal")]
        [Display(Name = "Local")]
        public string ObservacoesLocal { get; set; } = string.Empty;

        [Column("ObservacoesData")]
        [Display(Name = "Data")]
        public DateTime ObservacoesData { get; set; } = DateTime.MinValue;

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("PessoaId")]
        public int PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
    }
}
