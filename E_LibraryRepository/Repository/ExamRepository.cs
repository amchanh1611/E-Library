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

        public bool CreateExam(Exams exams)
        {
            _context.Exams.Add(exams);
            var check = _context.SaveChanges();
            return check>0?true:false;
        }

        public bool DeleteExamById(int id)
        {
            var exam = _context.Exams.Where(w=>w.ExamId==id).FirstOrDefault();
            _context.Exams.Remove(exam);
            var check = _context.SaveChanges();
            return check > 0?true:false;
        }

        public List<Exams> GetAllExam()
        {
            return _context.Exams.Include(i => i.Subjects).ToList();
        }

        public Exams GetExamById(int id)
        {
            return _context.Exams.Include(i=>i.Subjects).Where(w => w.ExamId == id).FirstOrDefault();
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