using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Questions")]
    public class Questions
    {
        [Key]
        public int QuestionId { get; set; }
        public int? ExamId { get; set; }
        public string? QuestionName { get; set; }
        public ICollection<Answers> Answers { get; set; }
        public Exams Exams { get; set; }
    }
}