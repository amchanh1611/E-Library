using E_Library.Common.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Documents")]
    public class Documents
    {
        [Key]
        public int DocumentId { get; set; }

        [MaxLength(250)]
        public string? DocumentName { get; set; }

        public bool? DocumentType { get; set; }
        public int? SubjectId { get; set; }
        public DateTime? DateSend { get; set; }
        public StatusApproveDocument? Status { get; set; }
        public Subjects Subjects { get; set; }

    }
}