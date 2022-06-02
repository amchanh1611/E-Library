using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IAnswerRepository
    {
        public List<Answers> GetAllAnswers();
        public Answers GetAnswerById(int id);
        public bool CreateAnswer(Answers answers);
        public bool UpdateAnswerById(Answers answers, int id);
        public bool DeleteAnswerById(int id);
    }
}