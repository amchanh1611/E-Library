using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Library.Models.Migrations
{
    public partial class Initial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PermisstionRoles",
                table: "PermisstionRoles");

            migrationBuilder.DropColumn(
                name: "PermistionId",
                table: "PermisstionRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermisstionRoles",
                table: "PermisstionRoles",
                columns: new[] { "RoleId", "PermisstionId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PermisstionRoles",
                table: "PermisstionRoles");

            migrationBuilder.AddColumn<int>(
                name: "PermistionId",
                table: "PermisstionRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermisstionRoles",
                table: "PermisstionRoles",
                columns: new[] { "RoleId", "PermistionId" });
        }
    }
}
