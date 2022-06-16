using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        public int? ExamId { get; set; }

        [MaxLength(10)]
        public string? QuestionCode { get; set; }

        public string? QuestionName { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public Exam Exam { get; set; }
    }
}