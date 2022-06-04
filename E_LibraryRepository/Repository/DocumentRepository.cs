using E_Library.Common.Enum;
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

        public IQueryable<Documents> FillAndSearchDocument(StatusApproveDocument? status, int subjectId, string? infoSearch)
        {
            IQueryable<Documents> query = _context.Documents;
            IQueryable<Subjects> subjects = _context.Subjects;
            if (status != null)
                query = query.Where(w => w.Status == status);
            if (subjectId != 0)
                query = query.Where(w => w.SubjectId == subjectId);
            if (infoSearch != null)
                query = from d in query
                        join s in subjects on d.SubjectId equals s.SubjectId
                        where d.DocumentName.Contains(infoSearch) || s.SubjectName.Contains(infoSearch)
                        select d;
            return query;
        }

        public IQueryable<Documents> GetAllDocument()
        {
            return _context.Documents;
        }

        public Documents GetDocumentById(int id)
        {
            return _context.Documents.Include(i => i.Subjects).Where(w => w.DocumentId == id).FirstOrDefault();
        }

        public bool UpdateDocumentById(Documents documents)
        {
            _context.Update(documents);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }
    }
}