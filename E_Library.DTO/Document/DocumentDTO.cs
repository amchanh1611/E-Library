using E_Library.Common.Enum;

namespace E_Library.DTO.Document
{
    public class DocumentDTO
    {
        public string? DocumentName { get; set; }
        public bool? DocumentType { get; set; }
        public StatusApproveDocument? Status { get; set; }
        public DateTime? DateSend { get; set; }
        public string? SubjectName { get; set; }
        public string? TeacherName { get; set; }
    }
}