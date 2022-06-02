using E_Library.DTO;
using E_Library.DTO.FunctionDTO;
using E_Library.Models;

namespace E_Library.BUS.IBUS
{
    public interface ISubjectBUS
    {
        public bool CreateSubject(SubjectDTO subjectDTO);

        public List<Subjects> GetAllSubject();

        public List<SubjectComboboxSubjectDTO> GetComboboxSubject();
        public List<Subjects> FillSubjectBySubjectSelected(int id);
        public List<Subjects> SearchSubject(SearchSubjectDTO searchSubjectDTO);
        public List<SubjectComboboxTeacherDTO> GetComboboxTeacher();
        public List<Subjects> FillSubjectByTeacherSelected(string? teacherName);
        public List<SubjectComboboxStatusDTO> GetComboboxStatus();
        public List<Subjects> FillSubjectByStatusSelected(bool? status);
    }
}