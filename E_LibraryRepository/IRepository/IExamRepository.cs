using E_Library.Common.Enum;
using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IExamRepository
    {
        public IQueryable<Exam> GetAllExam();

        public IQueryable<Exam> GetExamById(int id);

        public IQueryable<Exam> FillAndSearchExam(ExamStatus? status, int subjectId, string? teacherCreateExam, string? infoSearch);
        public Exam GetExamDetail(int id);
    }
}