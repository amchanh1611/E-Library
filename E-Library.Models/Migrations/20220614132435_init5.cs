using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Library.Models.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Subjects_SubjectsSubjectId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_SubjectsSubjectId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamsExamId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ExamsExamId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SubjectsSubjectId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Documents_SubjectsSubjectId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "ExamsExamId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "SubjectsSubjectId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SubjectsSubjectId",
                table: "Documents");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SubjectId",
                table: "Exams",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_SubjectId",
                table: "Documents",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Subjects_SubjectId",
                table: "Documents",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ExamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Subjects_SubjectId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ExamId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SubjectId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Documents_SubjectId",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "ExamsExamId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectsSubjectId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectsSubjectId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamsExamId",
                table: "Questions",
                column: "ExamsExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SubjectsSubjectId",
                table: "Exams",
                column: "SubjectsSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_SubjectsSubjectId",
                table: "Documents",
                column: "SubjectsSubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Subjects_SubjectsSubjectId",
                table: "Documents",
                column: "SubjectsSubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_SubjectsSubjectId",
                table: "Exams",
                column: "SubjectsSubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamsExamId",
                table: "Questions",
                column: "ExamsExamId",
                principalTable: "Exams",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
