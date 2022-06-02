using E_Library.DTO.FunctionDTO;
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

        public bool CreateSubject(Subjects subjects)
        {
            _context.Subjects.Add(subjects);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }

        public bool DeleteSubjectById(int id)
        {
            var subject = _context.Subjects.Where(w => w.SubjectId == id).FirstOrDefault();
            _context.Subjects.Remove(subject);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }

        public List<Subjects> GetAllSubject()
        {
            return _context.Subjects.ToList();
        }

        public List<SubjectComboboxStatusDTO> GetComboboxStatus()
        {
            return _context.Subjects.Select(w => new SubjectComboboxStatusDTO { StatusDocumentSuject = w.StatusDocumentSubject }).Distinct().ToList();
        }

        public List<SubjectComboboxSubjectDTO> GetComboboxSubject()
        {
            //var query = from s in _context.Subjects
            //            select new ComboboxSubjectDTO { SubjectId = s.SubjectId ,SubjectName = s.SubjectName};
            return _context.Subjects.Select(s => new SubjectComboboxSubjectDTO { SubjectId = s.SubjectId,SubjectName = s.SubjectName }).Distinct().ToList(); ;
        }

        public List<SubjectComboboxTeacherDTO> GetComboboxTeacher()
        {
            return _context.Subjects.Select(s => new SubjectComboboxTeacherDTO { TeacherName = s.TeacherName }).Distinct().ToList();
        }

        public List<Subjects> GetSubjectBySubject(int id)
        {
            return _context.Subjects.Where(w =>w.SubjectId == id).ToList();
        }

        public List<Subjects> GetSubjectByStatus(bool? status)
        {
            return _context.Subjects.Where(w => w.StatusDocumentSubject == status).ToList();
        }

        public List<Subjects> GetSubjectByTeacher(string? teacherName)
        {
            return _context.Subjects.Where(w => w.TeacherName == teacherName).ToList();
        }

        public List<Subjects> SearchSubject(SearchSubjectDTO searchSubjectDTO)
        {
            //var query = from s in _context.Subjects
            //            where s.SubjectName.Contains(searchSubjectDTO.InfoSearch) || s.TeacherName.Contains(searchSubjectDTO.InfoSearch)
            //            select new Subjects { SubjectCode =s.SubjectCode, SubjectName= s.SubjectName, TeacherName= s.TeacherName, StatusDocumentSubject= s.StatusDocumentSubject, DocumentWaitAprrove= s.DocumentWaitAprrove, DateAprrove= s.DateAprrove};
            //return query.ToList();
            return _context.Subjects.Where(w => w.SubjectName.Contains(searchSubjectDTO.InfoSearch) || w.TeacherName.Contains(searchSubjectDTO.InfoSearch)).ToList();
        }

        public bool UpdateSubjectById(Subjects subjects, int id)
        {
            _context.Update(subjects);
            var check = _context.SaveChanges();
            return check > 0 ? true : false;
        }
    }
}