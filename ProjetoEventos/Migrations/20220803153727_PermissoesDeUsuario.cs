using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoEventos.Migrations
{
    public partial class PermissoesDeUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "USUARIO_PERMISSOES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    PermissoesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO_PERMISSOES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USUARIO_PERMISSOES_PERMISSOES_PermissoesID",
                        column: x => x.PermissoesID,
                        principalTable: "PERMISSOES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USUARIO_PERMISSOES_USUARIO_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_USUARIO_PERMISSOES_PermissoesID",
                table: "USUARIO_PERMISSOES",
                column: "PermissoesID");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIO_PERMISSOES_UsuarioID",
                table: "USUARIO_PERMISSOES",
                column: "UsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USUARIO_PERMISSOES");
        }
    }
}
