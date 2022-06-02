using E_Library.Common.Enum;
using E_Library.DTO.Document;
using E_Library.DTO.FunctionDTO;
using E_Library.Models;
using E_Library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace E_Library.Repository.Repository
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly E_LibraryDbContext _context;

        public DocumentRepository(E_LibraryDbContext context)
        {
            _context = context;
        }

        public bool CreateDocument(Documents document)
        {
            _context.Documents.Add(document);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }

        public bool DeleteDocumentById(int id)
        {
            var document = _context.Documents.Where(w => w.DocumentId == id).FirstOrDefault();
            _context.Documents.Remove(document);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }

        public List<DocumentDTO> FillDocumentByStatus(StatusApproveDocument status)
        {
            var query = from d in _context.Documents
                        join s in _context.Subjects on d.SubjectId equals s.SubjectId
                        where d.Status == status
                        select new DocumentDTO { DocumentName = d.DocumentName, DocumentType = d.DocumentType, DateSend = d.DateSend, Status = d.Status, SubjectName = s.SubjectName, TeacherName = s.TeacherName };
            return query.ToList();
        }

        public List<DocumentDTO> FillDocumentBySubject(string? Name)
        {
            var query = from d in _context.Documents
                        join s in _context.Subjects on d.SubjectId equals s.SubjectId
                        where s.SubjectName == Name
                        select new DocumentDTO { DateSend = d.DateSend, DocumentName = d.DocumentName, DocumentType = d.DocumentType, Status = d.Status, SubjectName = s.SubjectName, TeacherName = s.TeacherName };
            return query.ToList();
        }

        public List<DocumentDTO> GetAllDocument()
        {
            var query = from d in _context.Documents
                        join s in _context.Subjects on d.SubjectId equals s.SubjectId
                        //select new { DocumentName = d.DocumentName, DocumentType = d.DocumentType, DateSend = d.DateSend, Status = d.Status, SubjectName = s.SubjectName, TeacherName = s.TeacherName };
                        select new DocumentDTO { DocumentName = d.DocumentName, DocumentType = d.DocumentType, DateSend = d.DateSend, Status = d.Status, SubjectName = s.SubjectName, TeacherName = s.TeacherName };
            var result = query.ToList();
            return result;
        }

        public List<DocumentComboboxStatusDTO> GetComboboxStatus()
        {
            return _context.Documents.Select(s => new DocumentComboboxStatusDTO { Status = s.Status }).Distinct().ToList();
        }

        public List<DocumentComboboxSubjectDTO> GetComboboxSubject()
        {
            var query = (from d in _context.Documents
                         join s in _context.Subjects on d.SubjectId equals s.SubjectId
                         select new DocumentComboboxSubjectDTO { SubjectName = s.SubjectName }).Distinct();
            return query.ToList();
        }

        public Documents GetDocumentById(int id)
        {
            return _context.Documents.Include(i => i.Subjects).Where(w => w.DocumentId == id).FirstOrDefault();
        }

        public List<DocumentDTO> SearchDocument(SearchSubjectDTO info)
        {
            var query = from d in _context.Documents
                        join s in _context.Subjects on d.SubjectId equals s.SubjectId
                        where d.DocumentName.Contains(info.InfoSearch) || s.SubjectName.Contains(info.InfoSearch)
                        select new DocumentDTO { DateSend = d.DateSend, DocumentName = d.DocumentName, DocumentType = d.DocumentType, Status = d.Status, SubjectName = s.SubjectName, TeacherName = s.TeacherName };
            return query.ToList();
        }

        public bool UpdateDocumentById(Documents documents)
        {
            _context.Update(documents);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }
    }
}