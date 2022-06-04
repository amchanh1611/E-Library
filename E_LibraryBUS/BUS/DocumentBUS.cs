using E_Library.BUS.IBUS;
using E_Library.DTO.Document;
using E_Library.DTO.FunctionDTO;
using E_Library.Repository.IRepository;

namespace E_Library.BUS.BUS
{
    public class DocumentBUS : IDocumentBUS
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly ISubjectRepository _subjectRepository;

        public DocumentBUS(IDocumentRepository documentRepository, ISubjectRepository subjectRepository)
        {
            _documentRepository = documentRepository;
            _subjectRepository = subjectRepository;
        }

        public List<DocumentDTO> FillAndSearchDocument(FillAndSearchDocumentDTO fillAndSearchDocument)
        {
            var documents = _documentRepository.FillAndSearchDocument(fillAndSearchDocument.Status, fillAndSearchDocument.SubjectId, fillAndSearchDocument.InfoSearch);
            var subjects = _subjectRepository.GetAllSubject();
            var result = from d in documents
                         join s in subjects on d.SubjectId equals s.SubjectId
                         select new DocumentDTO { DocumentType = d.DocumentType,DocumentName=d.DocumentName,SubjectName=s.SubjectName,TeacherName=s.TeacherName,Status=d.Status,DateSend=d.DateSend};
            return result.ToList();
        }

        public List<DocumentDTO> GetAllDocument()
        {
            var documents = _documentRepository.GetAllDocument();
            var subjects = _subjectRepository.GetAllSubject();
            var result = from d in documents
                         join s in subjects on d.SubjectId equals s.SubjectId
                         select new DocumentDTO { DocumentType = d.DocumentType, DocumentName = d.DocumentName, SubjectName = s.SubjectName, TeacherName = s.TeacherName, Status = d.Status, DateSend = d.DateSend };
            return result.ToList();
        }

        public List<DocumentComboboxStatusDTO> GetComboboxStatus()
        {
            var documents = _documentRepository.GetAllDocument();
            return documents.Select(s => new DocumentComboboxStatusDTO { Status = s.Status }).Distinct().ToList();
        }

        public List<DocumentComboboxSubjectDTO> GetComboboxSubject()
        {
            var documents = _documentRepository.GetAllDocument();
            var subjects = _subjectRepository.GetAllSubject();
            var result = from d in documents
                         join s in subjects on d.SubjectId equals s.SubjectId
                         select new DocumentComboboxSubjectDTO { SubjectId = s.SubjectId, SubjectName = s.SubjectName };
            return result.Distinct().ToList();
        }

        public bool UpdateApproveDocument(StatusApproveDocumentDTO document, int id)
        {
            var documents = _documentRepository.GetDocumentById(id);
            documents.Status = document.Status;
            return _documentRepository.UpdateDocumentById(documents);
        }
    }
}