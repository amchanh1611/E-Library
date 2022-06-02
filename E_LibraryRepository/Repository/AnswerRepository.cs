using E_Library.Models;
using E_Library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace E_Library.Repository.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly E_LibraryDbContext _context;
        public AnswerRepository(E_LibraryDbContext context)
        {
            _context = context;
        }

        public bool CreateAnswer(Answers answers)
        {
            _context.Answers.Add(answers);
            var check = _context.SaveChanges();
            return check>0?true:false;
        }

        public bool DeleteAnswerById(int id)
        {
            var answer = _context.Answers.Where(w=>w.AnswerId==id).FirstOrDefault();
            _context.Answers.Remove(answer);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }

        public List<Answers> GetAllAnswers()
        {
            return _context.Answers.Include(i=>i.Questions).ToList();
        }

        public Answers GetAnswerById(int id)
        {
            return _context.Answers.Include(i=>i.Questions).Where(w=>w.AnswerId == id).FirstOrDefault();
        }

        public bool UpdateAnswerById(Answers answers, int id)
        {
            var answer = _context.Answers.Where(w => w.AnswerId == id).FirstOrDefault();
            answer = answers;
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }
    }
}