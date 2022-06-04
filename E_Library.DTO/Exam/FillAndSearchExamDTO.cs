using E_Library.Common.Enum;

namespace E_Library.DTO.Exam
{
    public class FillAndSearchExamDTO
    {
        public ExamStatus? Status { get; set; }
        public int SubjectId { get; set; }
        public string? TeacherCreateExam { get; set; }
        public string? InfoSearch { get; set; }
    }
}