using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IAnswerRepository
    {
        public IQueryable<Answers> GetAllAnswers();

        public Answers GetAnswerById(int id);
    }
}