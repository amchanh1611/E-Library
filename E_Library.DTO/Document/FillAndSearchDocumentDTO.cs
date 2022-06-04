using E_Library.Common.Enum;

namespace E_Library.DTO.Document
{
    public class FillAndSearchDocumentDTO
    {
        public StatusApproveDocument? Status { get; set; }
        public int SubjectId { get; set; }
        public string? InfoSearch { get; set; }
    }
}