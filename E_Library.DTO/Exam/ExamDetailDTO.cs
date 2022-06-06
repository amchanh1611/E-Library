using E_Library.Common.Enum;
using E_Library.DTO.Answer;
using E_Library.DTO.Question;

namespace E_Library.DTO.Exam
{
    public class ExamDetailDTO
    {
        public string? SubjectName { get; set; }
        public ExamTime? Time { get; set; }
        public string? ExamName { get; set; }
        public ExamType? ExamType { get; set; }
        public string? TeacherCreateExam { get; set; }
        public DateTime? CreateDate { get; set; }
        public Dictionary<string, string> QuestionAndAnswer { get; set; }
        public QuestionDTO QuestionDefault { get; set; }
        public List<AnswerDTO> AnswersDefault { get; set; }
    }
}