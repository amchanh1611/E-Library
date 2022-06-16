using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface ISubjectRepository
    {
        public IQueryable<Subject> GetAllSubject();

        public IQueryable<Subject> FillAndSearchSubject(int subjectId, string? teacherName, bool? statusDocumentSubject, string infoSearch);
        public IQueryable<Subject> PagingSubject(int page);
    }
}