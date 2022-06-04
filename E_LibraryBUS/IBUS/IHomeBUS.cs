using E_Library.DTO.Home;

namespace E_Library.BUS.IBUS
{
    public interface IHomeBUS
    {
        public TotalExamDTO GetTotalExam();

        public TotalSubjectDTO GetTotalSubjects();
    }
}