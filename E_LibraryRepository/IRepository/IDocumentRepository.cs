using E_Library.Common.Enum;
using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IDocumentRepository
    {
        public IQueryable<Documents> GetAllDocument();

        public Documents GetDocumentById(int id);

        public bool UpdateDocumentById(Documents document);

        public IQueryable<Documents> FillAndSearchDocument(StatusApproveDocument? status, int subjectId, string? infoSearch);
    }
}