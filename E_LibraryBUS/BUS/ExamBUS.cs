using E_Library.BUS.IBUS;
using E_Library.DTO.Exam;
using E_Library.Repository.IRepository;

namespace E_Library.BUS.BUS
{
    public class ExamBUS : IExamBUS
    {
        private readonly IExamRepository _examRepository;
        private readonly ISubjectRepository _subjectRepository;
        public ExamBUS(IExamRepository examRepository, ISubjectRepository subjectRepository)
        {
            _examRepository = examRepository;
            _subjectRepository = subjectRepository;
        }

        public List<ExamDTO> FillAndSearchExam(FillAndSearchExamDTO fillAndSearchExam)
        {
            var exams = _examRepository.FillAndSearchExam(fillAndSearchExam.Status, fillAndSearchExam.SubjectId, fillAndSearchExam.TeacherCreateExam,fillAndSearchExam.InfoSearch);
            return exams.Select(s => new ExamDTO { TypeFile = s.TypeFile, ExamName = s.ExamName, Status = s.Status, SubjectId = s.SubjectId, TeacherCreateExam = s.TeacherCreateExam, Time = s.Time, Approve = s.Approve, ExamType = s.ExamType }).ToList();
        }

        public List<ExamDTO> GetAllExam()
        {
            var exams = _examRepository.GetAllExam();
            return exams.Select(s => new ExamDTO { TypeFile = s.TypeFile, ExamName = s.ExamName, ExamType = s.ExamType, TeacherCreateExam = s.TeacherCreateExam, Time = s.Time, SubjectId = s.SubjectId, Status = s.Status, Approve = s.Approve }).ToList();
        }

        public List<ExamComboboxStatusDTO> GetComboboxStatus()
        {
            var exams = _examRepository.GetAllExam();
            return exams.Select(s => new ExamComboboxStatusDTO { Status = s.Status }).Distinct().ToList();
        }

        public List<ExamComboboxSubjectDTO> GetComboboxSubject()
        {
            var exams = _examRepository.GetAllExam();
            var subjects = _subjectRepository.GetAllSubject();
            var query = from e in exams
                        join s in subjects on e.SubjectId equals s.SubjectId
                        select new ExamComboboxSubjectDTO { SubjectId = e.SubjectId, SubjectName = s.SubjectName };
            return query.Distinct().ToList();

        }

        public List<ExamComboboxTeacherDTO> GetComboboxTeacher()
        {
            var exams = _examRepository.GetAllExam();
            return exams.Select(s=>new ExamComboboxTeacherDTO { TeacherCreateExam = s.TeacherCreateExam}).Distinct().ToList();
        }
    }
}