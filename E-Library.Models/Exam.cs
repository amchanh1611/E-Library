using E_Library.Common.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Exams")]
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        public ExamTypeFile? TypeFile { get; set; }

        [MaxLength(250)]
        public string? ExamName { get; set; }

        public int? SubjectId { get; set; }

        [MaxLength(250)]
        public string? TeacherCreateExam { get; set; }

        public ExamType? ExamType { get; set; }

        public ExamTime? Time { get; set; }

        public ExamStatus? Status { get; set; }

        public ExamApprove? Approve { get; set; }

        public DateTime? CreateDate { get; set; }
        public ICollection<Question> Questions { get; set; }
        public Subject Subject { get; set; }
    }
}