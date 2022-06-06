using E_Library.DTO.Exam;
using E_Library.DTO.Question;

namespace E_Library.BUS.IBUS
{
    public interface IExamBUS
    {
        public List<ExamDTO> GetAllExam();

        public List<ExamComboboxStatusDTO> GetComboboxStatus();

        public List<ExamComboboxSubjectDTO> GetComboboxSubject();

        public List<ExamComboboxTeacherDTO> GetComboboxTeacher();

        public List<ExamDTO> FillAndSearchExam(FillAndSearchExamDTO fillAndSearchExam);

        public ExamDetailDTO GetExamDetailById(int id);
        public QuestionAndAnswerDetailDTO ClickQuestion(int questionId);
    }
}