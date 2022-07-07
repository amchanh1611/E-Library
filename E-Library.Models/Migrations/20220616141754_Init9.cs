using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Library.Models.Migrations
{
    public partial class Init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermisstionRoles_Permisstions_PermisstionID",
                table: "PermisstionRoles");

            migrationBuilder.RenameColumn(
                name: "PermisstionID",
                table: "Permisstions",
                newName: "PermisstionId");

            migrationBuilder.RenameColumn(
                name: "PermisstionID",
                table: "PermisstionRoles",
                newName: "PermisstionId");

            migrationBuilder.RenameIndex(
                name: "IX_PermisstionRoles_PermisstionID",
                table: "PermisstionRoles",
                newName: "IX_PermisstionRoles_PermisstionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermisstionRoles_Permisstions_PermisstionId",
                table: "PermisstionRoles",
                column: "PermisstionId",
                principalTable: "Permisstions",
                principalColumn: "PermisstionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermisstionRoles_Permisstions_PermisstionId",
                table: "PermisstionRoles");

            migrationBuilder.RenameColumn(
                name: "PermisstionId",
                table: "Permisstions",
                newName: "PermisstionID");

            migrationBuilder.RenameColumn(
                name: "PermisstionId",
                table: "PermisstionRoles",
                newName: "PermisstionID");

            migrationBuilder.RenameIndex(
                name: "IX_PermisstionRoles_PermisstionId",
                table: "PermisstionRoles",
                newName: "IX_PermisstionRoles_PermisstionID");

            migrationBuilder.AddForeignKey(
                name: "FK_PermisstionRoles_Permisstions_PermisstionID",
                table: "PermisstionRoles",
                column: "PermisstionID",
                principalTable: "Permisstions",
                principalColumn: "PermisstionID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
