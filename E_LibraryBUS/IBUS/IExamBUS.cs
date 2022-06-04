using E_Library.Common.Enum;
using E_Library.DTO;
using E_Library.DTO.Exam;

namespace E_Library.BUS.IBUS
{
    public interface IExamBUS
    {
        public List<ExamDTO> GetAllExam();
        public List<ExamComboboxStatusDTO> GetComboboxStatus();
        public List<ExamComboboxSubjectDTO> GetComboboxSubject();
        public List<ExamComboboxTeacherDTO> GetComboboxTeacher();
        public List<ExamDTO> FillAndSearchExam(FillAndSearchExamDTO fillAndSearchExam);
    }
}