using E_Library.Common.Enum.PrivateFile;

namespace E_Library.DTO.PrivateFile
{
    public class PrivateFileUploadedDTO
    {
        public PrivateFileType? PrivateFileType { get; set; }
        public string? PrivateFileName { get; set; }
        public double? Size { get; set; }
    }
}