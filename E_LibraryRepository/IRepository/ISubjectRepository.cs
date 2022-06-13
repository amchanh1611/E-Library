using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface ISubjectRepository
    {
        public IQueryable<Subjects> GetAllSubject();

        public IQueryable<Subjects> FillAndSearchSubject(int subjectId, string? teacherName, bool? statusDocumentSubject, string infoSearch);
        public IQueryable<Subjects> PagingSubject(int page);
    }
}