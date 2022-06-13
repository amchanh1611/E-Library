using E_Library.BUS.IBUS;
using E_Library.DTO.Subject;
using E_Library.Repository.IRepository;

namespace E_Library.BUS.BUS
{
    public class SubjectBUS : ISubjectBUS
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectBUS(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public List<SubjectDTO> GetAllSubject()
        {
            var subjects = _subjectRepository.GetAllSubject();
            return subjects.Select(s => new SubjectDTO { SubjectCode = s.SubjectCode, SubjectName = s.SubjectName, TeacherName = s.TeacherName, DocumentWaitAprrove = s.DocumentWaitAprrove, StatusDocumentSubject = s.StatusDocumentSubject, DateAprrove = s.DateAprrove }).ToList();
        }

        public List<SubjectComboboxSubjectDTO> GetComboboxSubject()
        {
            var subjects = _subjectRepository.GetAllSubject();
            return subjects.Select(s => new SubjectComboboxSubjectDTO { SubjectId = s.SubjectId, SubjectName = s.SubjectName }).Distinct().ToList();
        }

        public List<SubjectComboboxTeacherDTO> GetComboboxTeacher()
        {
            var subjects = _subjectRepository.GetAllSubject();
            return subjects.Select(s => new SubjectComboboxTeacherDTO { TeacherName = s.TeacherName }).Distinct().ToList();
        }

        public List<SubjectComboboxStatusDTO> GetComboboxStatus()
        {
            var subject = _subjectRepository.GetAllSubject();
            return subject.Select(s => new SubjectComboboxStatusDTO { StatusDocumentSuject = s.StatusDocumentSubject }).Distinct().ToList();
        }

        public List<SubjectDTO> FillAndSearchSubject(FillAndSearchSubjectDTO fillAndSearchSubjectDTO)
        {
            var subjects = _subjectRepository.FillAndSearchSubject(fillAndSearchSubjectDTO.SubjectId, fillAndSearchSubjectDTO.TeacherName, fillAndSearchSubjectDTO.StatusDocumentSubject, fillAndSearchSubjectDTO.InfoSearch);
            return subjects.Select(s => new SubjectDTO { SubjectCode = s.SubjectCode, SubjectName = s.SubjectName, TeacherName = s.TeacherName, DocumentWaitAprrove = s.DocumentWaitAprrove, StatusDocumentSubject = s.StatusDocumentSubject, DateAprrove = s.DateAprrove }).ToList();
        }

        public SubjectPagingDTO SubjectPaging(int page)
        {
            var subjectCount = _subjectRepository.GetAllSubject().Count();
            var subjectPage = _subjectRepository.PagingSubject(page);
            var subjectDTO = subjectPage.Select(s => new SubjectDTO { SubjectCode = s.SubjectCode, SubjectName = s.SubjectName, TeacherName = s.TeacherName, DateAprrove = s.DateAprrove, DocumentWaitAprrove = s.DocumentWaitAprrove, StatusDocumentSubject = s.StatusDocumentSubject }).ToList();

            var pageNumber = (int)Math.Ceiling((decimal)subjectCount / 2);

            return new SubjectPagingDTO { PageNumber = pageNumber, PageNow = page, Subject = subjectDTO };
        }
    }
}