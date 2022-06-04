using E_Library.BUS.IBUS;
using E_Library.DTO.Home;
using E_Library.Repository.IRepository;

namespace E_Library.BUS.BUS
{
    public class HomeBUS : IHomeBUS
    {
        private readonly IExamRepository _examRepository;
        private readonly ISubjectRepository _subjectRepository;

        public HomeBUS(IExamRepository examRepository, ISubjectRepository subjectRepository)
        {
            _examRepository = examRepository;
            _subjectRepository = subjectRepository;
        }

        public TotalExamDTO GetTotalExam()
        {
            var exams = _examRepository.GetAllExam();
            return new TotalExamDTO { TotalExam = exams.ToList().Count };
        }

        public TotalSubjectDTO GetTotalSubjects()
        {
            var subjects = _subjectRepository.GetAllSubject();
            var homeSubject = subjects.Select(s => new HomeSubjectDTO { SubjectCode = s.SubjectCode, SubjectName = s.SubjectName }).ToList();
            return new TotalSubjectDTO { HomeSuject = homeSubject, TotalCount = subjects.ToList().Count };
        }
    }
}