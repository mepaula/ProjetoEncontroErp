using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEncontro.Models
{
    [Table("Usuario")]
    public class Usuario
    {
            [Column("Id_Usuario")]
            [Display(Name = "Código")]
            public int Id { get; set; }

            [Column("UsuarioNome")]
            [Display(Name = "Nome do Usuario")]
            public string UsuarioNome { get; set; } = string.Empty;

            [Column("UsuarioTelefone")]
            [Display(Name = "Coloque seu Telefone")]
            public string UsuarioTelefone { get; set; } = string.Empty;

            [Column("UsuarioEmail")]
            [Display(Name = "Coloque seu Email")]
            public string UsuarioEmail { get; set; } = string.Empty;

            [Column("UsuarioSenha")]
            [Display(Name = "Coloque sua Senha")]
            public string UsuarioSenha { get; set; } = string.Empty;
    }
}
