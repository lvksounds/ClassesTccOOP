using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Waise.Portal.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Instituicoes_InstituicaoID",
                table: "Cursos");

            migrationBuilder.RenameColumn(
                name: "InstituicaoID",
                table: "Cursos",
                newName: "InstituicaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_InstituicaoID",
                table: "Cursos",
                newName: "IX_Cursos_InstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Instituicoes_InstituicaoId",
                table: "Cursos",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Instituicoes_InstituicaoId",
                table: "Cursos");

            migrationBuilder.RenameColumn(
                name: "InstituicaoId",
                table: "Cursos",
                newName: "InstituicaoID");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_InstituicaoId",
                table: "Cursos",
                newName: "IX_Cursos_InstituicaoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Instituicoes_InstituicaoID",
                table: "Cursos",
                column: "InstituicaoID",
                principalTable: "Instituicoes",
                principalColumn: "ID");
        }
    }
}
