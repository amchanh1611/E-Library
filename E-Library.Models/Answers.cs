using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library.Models
{
    [Table("Answers")]
    public class Answers
    {
        [Key]
        public int AnswerId { get; set; }
        public int? QuestionId { get; set; }
        public string? AnswerName { get; set; }
        public bool? CorrectAnswer { get; set; }
        public Questions Questions { get; set; }
        
    }
}
