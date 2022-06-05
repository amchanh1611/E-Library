using E_Library.Common.Enum;
using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IExamRepository
    {
        public IQueryable<Exams> GetAllExam();

        public IQueryable<Exams> GetExamById(int id);

        public IQueryable<Exams> FillAndSearchExam(ExamStatus? status, int subjectId, string? teacherCreateExam, string? infoSearch);
    }
}