using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IExamRepository
    {
        public List<Exams> GetAllExam();
        public Exams GetExamById(int id);
        public bool CreateExam(Exams exams);
        public bool UpdateExamById(Exams exams,int id);
        public bool DeleteExamById(int id);
    }
}