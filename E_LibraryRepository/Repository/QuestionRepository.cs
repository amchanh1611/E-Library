using E_Library.Models;
using E_Library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace E_Library.Repository.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly E_LibraryDbContext _context;
        public QuestionRepository(E_LibraryDbContext context)
        {
            _context = context;
        }

        public bool CreateQuestion(Questions questions)
        {
            _context.Questions.Add(questions);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;

        }

        public bool DeleteQuestionById(int id)
        {
            var question = _context.Questions.Where(w=>w.QuestionId == id).FirstOrDefault();
            _context.Questions.Remove(question);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }

        public List<Questions> GetAllQuestion()
        {
            return _context.Questions.Include(i=>i.Exams).ToList();
        }

        public Questions GetQuestionById(int id)
        {
            return  _context.Questions.Include(i=>i.Exams).Where(w=>w.QuestionId==id).FirstOrDefault();
        }

        public bool UpdateQuestionById(Questions questions, int id)
        {
            var question = _context.Questions.Where(w => w.QuestionId == id).FirstOrDefault();
            question = questions;
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }
    }
}