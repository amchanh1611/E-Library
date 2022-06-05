using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Answers")]
    public class Answers
    {
        [Key]
        public int AnswerId { get; set; }

        public int? QuestionId { get; set; }

        [MaxLength(1)]
        [Column(TypeName = "varchar")]
        public string? AnswerCode { get; set; }

        public string? AnswerName { get; set; }
        public bool? CorrectAnswer { get; set; }
        public Questions Questions { get; set; }
    }
}