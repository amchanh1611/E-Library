using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Subjects")]
    public class Subjects
    {
        [Key]
        public int SubjectId { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string? SubjectCode { get; set; }

        [MaxLength(250)]
        public string? SubjectName { get; set; }

        [MaxLength(50)]
        public string? TeacherName { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        public string? DocumentWaitAprrove { get; set; }

        public bool? StatusDocumentSubject { get; set; }
        public DateTime? DateAprrove { get; set; }
        public ICollection<Documents> Documents { get; set; }
        public ICollection<Exams> Exams { get; set; }
    }
}