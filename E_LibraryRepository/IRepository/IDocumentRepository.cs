using E_Library.Common.Enum;
using E_Library.DTO.Document;
using E_Library.DTO.FunctionDTO;
using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IDocumentRepository
    {
        public List<DocumentDTO> GetAllDocument();
        public Documents GetDocumentById(int id);
        public bool CreateDocument(Documents document);
        public bool UpdateDocumentById(Documents document);
        public bool DeleteDocumentById(int id);
        public List<DocumentComboboxStatusDTO> GetComboboxStatus();
        public List<DocumentComboboxSubjectDTO> GetComboboxSubject();
        public List<DocumentDTO> FillDocumentByStatus(StatusApproveDocument status);
        public List<DocumentDTO> FillDocumentBySubject(string? subjectName);
        public List<DocumentDTO> SearchDocument(SearchSubjectDTO info);
    }
}