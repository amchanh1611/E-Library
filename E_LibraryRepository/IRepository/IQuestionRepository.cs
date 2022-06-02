using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IQuestionRepository
    {
        public List<Questions> GetAllQuestion();
        public Questions GetQuestionById(int id);
        public bool CreateQuestion(Questions questions);
        public bool UpdateQuestionById(Questions questions,int id);
        public bool DeleteQuestionById(int id);
    }
}