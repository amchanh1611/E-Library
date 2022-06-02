using E_Library.BUS.IBUS;
using E_Library.DTO;
using E_Library.DTO.FunctionDTO;
using E_Library.Models;
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

        public bool CreateSubject(SubjectDTO subjectDTO)
        {
            var dateTimeApprove = DateTime.TryParse(subjectDTO.DateAprrove,
                       out var dt);
            if (dateTimeApprove)
            {
                var result = _subjectRepository.CreateSubject(new Subjects
                {
                    SubjectCode = subjectDTO.SubjectCode,
                    SubjectName = subjectDTO.SubjectName,
                    TeacherName = subjectDTO.TeacherName,
                    DocumentWaitAprrove = subjectDTO.DocumentWaitAprrove,
                    StatusDocumentSubject = subjectDTO.StatusDocumentSubject,
                    DateAprrove = dt
                });
                if (result)
                    return true;
            }
            return false;
        }

        public List<Subjects> GetAllSubject()
        {
            var result = _subjectRepository.GetAllSubject();
            return result;
        }

        public List<SubjectComboboxSubjectDTO> GetComboboxSubject()
        {
            return _subjectRepository.GetComboboxSubject();
        }

        public List<Subjects> FillSubjectBySubjectSelected(int id)
        {
            return _subjectRepository.GetSubjectBySubject(id);
        }

        public List<Subjects> SearchSubject(SearchSubjectDTO searchSubjectDTO)
        {
            return _subjectRepository.SearchSubject(searchSubjectDTO);
        }

        public List<SubjectComboboxTeacherDTO> GetComboboxTeacher()
        {
            return _subjectRepository.GetComboboxTeacher();
        }

        public List<Subjects> FillSubjectByTeacherSelected(string? teacherName)
        {
            return _subjectRepository.GetSubjectByTeacher(teacherName);
        }

        public List<SubjectComboboxStatusDTO> GetComboboxStatus()
        {
            return _subjectRepository.GetComboboxStatus();
        }

        public List<Subjects> FillSubjectByStatusSelected(bool? status)
        {
            return _subjectRepository.GetSubjectByStatus(status);
        }
    }
}