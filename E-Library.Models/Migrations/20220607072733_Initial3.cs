using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Library.Models.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrivateFiles",
                columns: table => new
                {
                    PrivateFileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivateFileType = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    PrivateFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Editor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastDateEdit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Size = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateFiles", x => x.PrivateFileId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrivateFiles");
        }
    }
}
