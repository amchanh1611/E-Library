using E_Library.Common.Enum.PrivateFile;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("PrivateFiles")]
    public class PrivateFile
    {
        [Key]
        public int PrivateFileId { get; set; }

        public PrivateFileType? PrivateFileType { get; set; }

        public string? PrivateFileName { get; set; }

        [MaxLength(250)]
        public string? Editor { get; set; }

        public DateTime? LastDateEdit { get; set; }

        [Column(TypeName = "float")]
        public double? Size { get; set; }
    }
}