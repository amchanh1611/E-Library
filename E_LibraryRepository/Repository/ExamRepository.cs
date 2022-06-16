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

        public IQueryable<Exam> FillAndSearchExam(ExamStatus? status, int subjectId, string? teacherCreateExam, string? infoSearch)
        {
            IQueryable<Exam> query = _context.Exams.Include(i=>i.Subject);
            IQueryable<Subject> subjects = _context.Subjects;
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

        public IQueryable<Exam> GetAllExam()
        {
            return _context.Exams.Include(i=>i.Subject);
        }

        public IQueryable<Exam> GetExamById(int id)
        {
            return _context.Exams.Where(w => w.ExamId == id);
        }

        public bool UpdateExamById(Exam exams, int id)
        {
            var exam = _context.Exams.Where(w => w.ExamId == id).FirstOrDefault();
            exam = exams;
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }

        public Exam GetExamDetail(int id)
        {
            var exams = _context.Exams.Where(x => x.ExamId == id).Include(x => x.Subject).Include(x => x.Questions).ThenInclude(x => x.Answers).FirstOrDefault();
            return exams;
        }
    }
}