using E_Library.Common.Enum.PrivateFile;

namespace E_Library.DTO.PrivateFile
{
    public class PrivateFileDTO
    {
        public PrivateFileType? PrivateFileType { get; set; }
        public string? PrivateFileName { get; set; }
        public string? Editor { get; set; }
        public DateTime? LastDateEdit { get; set; }
        public double? Size { get; set; }
    }
}