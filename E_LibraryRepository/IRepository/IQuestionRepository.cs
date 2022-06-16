using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IQuestionRepository
    {
        public Question GetQuestionById(int id);
    }
}