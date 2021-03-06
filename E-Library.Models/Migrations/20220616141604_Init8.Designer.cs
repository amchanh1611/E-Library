// <auto-generated />
using System;
using E_Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Library.Models.Migrations
{
    [DbContext(typeof(E_LibraryDbContext))]
    [Migration("20220616141604_Init8")]
    partial class Init8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("E_Library.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnswerId"), 1L, 1);

                    b.Property<string>("AnswerCode")
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)");

                    b.Property<string>("AnswerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("CorrectAnswer")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("E_Library.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"), 1L, 1);

                    b.Property<DateTime?>("DateSend")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool?>("DocumentType")
                        .HasColumnType("bit");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("DocumentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("E_Library.Models.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"), 1L, 1);

                    b.Property<int?>("Approve")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("ExamType")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherCreateExam")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("Time")
                        .HasColumnType("int");

                    b.Property<int?>("TypeFile")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("E_Library.Models.Permisstion", b =>
                {
                    b.Property<int>("PermisstionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermisstionID"), 1L, 1);

                    b.Property<int>("PermisstionName")
                        .HasColumnType("int");

                    b.HasKey("PermisstionID");

                    b.ToTable("Permisstions");
                });

            modelBuilder.Entity("E_Library.Models.PermistionRole", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("PermistionId")
                        .HasColumnType("int");

                    b.Property<int>("PermisstionID")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "PermistionId");

                    b.HasIndex("PermisstionID");

                    b.ToTable("PermisstionRoles");
                });

            modelBuilder.Entity("E_Library.Models.PrivateFile", b =>
                {
                    b.Property<int>("PrivateFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrivateFileId"), 1L, 1);

                    b.Property<string>("Editor")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("LastDateEdit")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrivateFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrivateFileType")
                        .HasColumnType("int");

                    b.Property<double?>("Size")
                        .HasColumnType("float");

                    b.HasKey("PrivateFileId");

                    b.ToTable("PrivateFiles");
                });

            modelBuilder.Entity("E_Library.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"), 1L, 1);

                    b.Property<int?>("ExamId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("QuestionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.HasIndex("ExamId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("E_Library.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<int>("RoleName")
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("E_Library.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<DateTime?>("DateAprrove")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentWaitAprrove")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("StatusDocumentSubject")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectCode")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("SubjectName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TeacherName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("E_Library.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("LoginName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Password")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("E_Library.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("E_Library.Models.Answer", b =>
                {
                    b.HasOne("E_Library.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("E_Library.Models.Document", b =>
                {
                    b.HasOne("E_Library.Models.Subject", "Subject")
                        .WithMany("Documents")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("E_Library.Models.Exam", b =>
                {
                    b.HasOne("E_Library.Models.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("E_Library.Models.PermistionRole", b =>
                {
                    b.HasOne("E_Library.Models.Permisstion", "Permisstion")
                        .WithMany()
                        .HasForeignKey("PermisstionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Library.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permisstion");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("E_Library.Models.Question", b =>
                {
                    b.HasOne("E_Library.Models.Exam", "Exam")
                        .WithMany("Questions")
                        .HasForeignKey("ExamId");

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("E_Library.Models.UserRole", b =>
                {
                    b.HasOne("E_Library.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Library.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Library.Models.Exam", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("E_Library.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("E_Library.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("E_Library.Models.Subject", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Exams");
                });

            modelBuilder.Entity("E_Library.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
