using E_Library.BUS.IBUS;
using E_Library.Common.Enum;
using E_Library.DTO.Document;
using E_Library.DTO.FunctionDTO;
using E_Library.Models;
using E_Library.Repository.IRepository;

namespace E_Library.BUS.BUS
{
    public class DocumentBUS : IDocumentBUS
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentBUS(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public List<DocumentDTO> FillDocumentByStatus(StatusApproveDocument status)
        {
            return _documentRepository.FillDocumentByStatus(status);
        }

        public List<DocumentDTO> FillDocumentBySubject(string? subjectName)
        {
            return _documentRepository.FillDocumentBySubject(subjectName);
        }

        public object GetAllDocument()
        {
            return _documentRepository.GetAllDocument();
        }

        public List<DocumentComboboxStatusDTO> GetComboboxStatus()
        {
            return _documentRepository.GetComboboxStatus();
        }

        public List<DocumentComboboxSubjectDTO> GetComboboxSubject()
        {
            return _documentRepository.GetComboboxSubject();
        }

        public List<DocumentDTO> SearchDocument(SearchSubjectDTO info)
        {
            return _documentRepository.SearchDocument(info);
        }

        public bool UpdateApproveDocument(StatusApproveDocumentDTO document, int id)
        {
            var documents = _documentRepository.GetDocumentById(id);
            documents.Status = document.Status;
            return _documentRepository.UpdateDocumentById(documents);
        }
    }
}