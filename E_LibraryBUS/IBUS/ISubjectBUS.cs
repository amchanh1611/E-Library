using E_Library.DTO.Subject;

namespace E_Library.BUS.IBUS
{
    public interface ISubjectBUS
    {
        public List<SubjectDTO> GetAllSubject();

        public List<SubjectComboboxSubjectDTO> GetComboboxSubject();

        public List<SubjectComboboxTeacherDTO> GetComboboxTeacher();

        public List<SubjectComboboxStatusDTO> GetComboboxStatus();

        public List<SubjectDTO> FillAndSearchSubject(FillAndSearchSubjectDTO fillAndSearchSubjectDTO);
        public SubjectPagingDTO SubjectPaging(int page);
    }
}