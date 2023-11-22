using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_carrinho_dotnet.Migrations
{
    public partial class AddUsuarioAoCarrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Carrinho",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_UsuarioId",
                table: "Carrinho",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinho_Usuario_UsuarioId",
                table: "Carrinho",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinho_Usuario_UsuarioId",
                table: "Carrinho");

            migrationBuilder.DropIndex(
                name: "IX_Carrinho_UsuarioId",
                table: "Carrinho");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Carrinho");
        }
    }
}
