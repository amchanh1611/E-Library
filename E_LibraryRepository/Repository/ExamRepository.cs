using E_Library.Common.Enum;
using E_Library.Models;
using E_Library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace E_Library.Repository.Repository
{
    public class ExamRepository : IExamRepository
    {
        private readonly E_LibraryDbContext _context;

        public ExamRepository(E_LibraryDbContext context)
        {
            _context = context;
        }

        public IQueryable<Exams> FillAndSearchExam(ExamStatus? status, int subjectId, string? teacherCreateExam, string? infoSearch)
        {
            IQueryable<Exams> query = _context.Exams;
            IQueryable<Subjects> subjects = _context.Subjects;
            if (status != null)
                query = query.Where(w => w.Status == status);
            if (subjectId != 0)
                query = query.Where(w => w.SubjectId == subjectId);
            if (teacherCreateExam != null)
                query = query.Where(w => w.TeacherCreateExam == teacherCreateExam);
            if (infoSearch != null)
                query = from e in query
                        join s in subjects on e.SubjectId equals s.SubjectId
                        where e.ExamName.Contains(infoSearch) || s.SubjectName.Contains(infoSearch)
                        select e;
            return query;
        }

        public IQueryable<Exams> GetAllExam()
        {
            return _context.Exams;
        }

        public Exams GetExamById(int id)
        {
            return _context.Exams.Include(i => i.Subjects).Where(w => w.ExamId == id).FirstOrDefault();
        }

        public bool UpdateExamById(Exams exams, int id)
        {
            var exam = _context.Exams.Where(w => w.ExamId == id).FirstOrDefault();
            exam = exams;
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }
    }
}