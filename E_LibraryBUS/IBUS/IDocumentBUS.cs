using E_Library.Common.Enum;
using E_Library.DTO.Document;
using E_Library.DTO.FunctionDTO;
using E_Library.Models;

namespace E_Library.BUS.IBUS
{
    public interface IDocumentBUS
    {
        public object GetAllDocument();

        public bool UpdateApproveDocument(StatusApproveDocumentDTO document, int id);
        public List<DocumentComboboxStatusDTO> GetComboboxStatus();
        public List<DocumentComboboxSubjectDTO> GetComboboxSubject();
        public List<DocumentDTO> FillDocumentByStatus(StatusApproveDocument status);
        public List<DocumentDTO> FillDocumentBySubject(string? subjectName);
        public List<DocumentDTO> SearchDocument(SearchSubjectDTO info);
    }
}