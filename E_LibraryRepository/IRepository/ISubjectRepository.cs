using E_Library.DTO.FunctionDTO;
using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface ISubjectRepository
    {
        public List<Subjects> GetAllSubject();
        public bool CreateSubject(Subjects subjects);
        public bool UpdateSubjectById(Subjects subjects,int id);
        public bool DeleteSubjectById(int id);
        public List<Subjects> GetSubjectBySubject(int id);
        public List<SubjectComboboxSubjectDTO> GetComboboxSubject();
        public List<Subjects> SearchSubject(SearchSubjectDTO searchSubjectDTO);
        public List<SubjectComboboxTeacherDTO> GetComboboxTeacher();
        public List<Subjects> GetSubjectByTeacher(string? teacherName);
        public List<SubjectComboboxStatusDTO> GetComboboxStatus();
        public List<Subjects> GetSubjectByStatus(bool? status);
    }
}