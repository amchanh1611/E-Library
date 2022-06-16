using E_Library.Models;
using E_Library.Repository.IRepository;

namespace E_Library.Repository.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly E_LibraryDbContext _context;

        public SubjectRepository(E_LibraryDbContext context)
        {
            _context = context;
        }

        public IQueryable<Subject> FillAndSearchSubject(int subjectId, string? teacherName, bool? statusDocumentSubject, string infoSearch)
        {
            IQueryable<Subject> query = _context.Subjects;
            if (subjectId != 0)
                query = query.Where(w => w.SubjectId == subjectId);
            if (teacherName != null)
                query = query.Where(w => w.TeacherName == teacherName);
            if (statusDocumentSubject != null)
                query = query.Where(w => w.StatusDocumentSubject == statusDocumentSubject);
            if (infoSearch != null)
                query = query.Where(w => w.SubjectName.Contains(infoSearch) || w.TeacherName.Contains(infoSearch));
            return query;
        }

        public IQueryable<Subject> GetAllSubject()
        {
            return _context.Subjects;
        }

        public IQueryable<Subject> PagingSubject(int page)
        {
            var subject = _context.Subjects.OrderBy(s => s.SubjectId).Skip((page - 1) * 2).Take(2);
            return subject;
        }
    }
}