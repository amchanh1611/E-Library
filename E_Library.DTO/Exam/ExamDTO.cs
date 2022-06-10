using E_Library.Common.Enum;

namespace E_Library.DTO.Exam
{
    public class ExamDTO
    {
        public ExamTypeFile? TypeFile { get; set; }

        public string? ExamName { get; set; }

        public string? SubjectName { get; set; }

        public string? TeacherCreateExam { get; set; }

        public ExamType? ExamType { get; set; }

        public ExamTime? Time { get; set; }

        public ExamStatus? Status { get; set; }

        public ExamApprove? Approve { get; set; }
    }
}