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

        public IQueryable<Answers> GetAllAnswers()
        {
            return _context.Answers;
        }

        public Answers GetAnswerById(int id)
        {
            return _context.Answers.Include(i => i.Questions).Where(w => w.AnswerId == id).FirstOrDefault();
        }
    }
}