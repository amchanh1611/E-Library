using E_Library.Common.Enum;
using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IDocumentRepository
    {
        public IQueryable<Document> GetAllDocument();

        public Document GetDocumentById(int id);

        public bool UpdateDocumentById(Document document);

        public IQueryable<Document> FillAndSearchDocument(StatusApproveDocument? status, int subjectId, string? infoSearch);
    }
}