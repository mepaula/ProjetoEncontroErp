using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoEncontro.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoPessoa1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PessoaLocoalDesaparecimento",
                table: "Pessoa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PessoaLocoalDesaparecimento",
                table: "Pessoa");
        }
    }
}
