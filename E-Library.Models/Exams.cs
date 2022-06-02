using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Exams")]
    public class Exams
    {
        [Key]
        public int ExamId { get; set; }
        public byte? TypeFile { get; set; }

        [MaxLength(250)]
        public string? ExamName { get; set; }

        public int? SubjectId { get; set; }

        [MaxLength(250)]
        public string? TeacherCreateExam { get; set; }

        public bool? ExamType { get; set; }

        public byte? Time { get; set; }

        public byte? Status { get; set; }

        public byte? Approve { get; set; }

        public DateTime? CreateDate { get; set; }
        public ICollection<Questions> Questions { get; set; }
        public Subjects Subjects { get; set; }
    }
}