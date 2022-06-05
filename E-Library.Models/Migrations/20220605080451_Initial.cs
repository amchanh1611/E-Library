using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Library.Models.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuestionCode",
                table: "Questions",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerCode",
                table: "Answers",
                type: "varchar(1)",
                maxLength: 1,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionCode",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AnswerCode",
                table: "Answers");
        }
    }
}
