﻿// <auto-generated />
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
    [Migration("20220605080451_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("E_Library.Models.Answers", b =>
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

                    b.Property<int>("QuestionsQuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionsQuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("E_Library.Models.Documents", b =>
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

                    b.Property<int>("SubjectsSubjectId")
                        .HasColumnType("int");

                    b.HasKey("DocumentId");

                    b.HasIndex("SubjectsSubjectId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("E_Library.Models.Exams", b =>
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

                    b.Property<int>("SubjectsSubjectId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherCreateExam")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("Time")
                        .HasColumnType("int");

                    b.Property<int?>("TypeFile")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("SubjectsSubjectId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("E_Library.Models.Questions", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"), 1L, 1);

                    b.Property<int?>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("ExamsExamId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("QuestionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.HasIndex("ExamsExamId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("E_Library.Models.Subjects", b =>
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

            modelBuilder.Entity("E_Library.Models.Answers", b =>
                {
                    b.HasOne("E_Library.Models.Questions", "Questions")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionsQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("E_Library.Models.Documents", b =>
                {
                    b.HasOne("E_Library.Models.Subjects", "Subjects")
                        .WithMany("Documents")
                        .HasForeignKey("SubjectsSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("E_Library.Models.Exams", b =>
                {
                    b.HasOne("E_Library.Models.Subjects", "Subjects")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectsSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("E_Library.Models.Questions", b =>
                {
                    b.HasOne("E_Library.Models.Exams", "Exams")
                        .WithMany("Questions")
                        .HasForeignKey("ExamsExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exams");
                });

            modelBuilder.Entity("E_Library.Models.Exams", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("E_Library.Models.Questions", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("E_Library.Models.Subjects", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
