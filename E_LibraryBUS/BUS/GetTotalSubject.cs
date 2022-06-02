using E_Library.BUS.IBUS;
using E_Library.DTO;
using E_Library.Repository.IRepository;

namespace E_Library.BUS.BUS
{
    public class GetTotalSubject : IGetTotalSubject
    {
        private readonly ISubjectRepository _subjectRepository;

        public GetTotalSubject(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public TotalSubjectDTO GetTotalSubjects()
        {
            var result = _subjectRepository.GetAllSubject();
            List<HomeSubjectDTO> homeSubject = new List<HomeSubjectDTO>();
            foreach (var subject in result)
            {
                homeSubject.Add(new HomeSubjectDTO
                {
                    SubjectCode = subject.SubjectCode,
                    SubjectName = subject.SubjectName,
                });
            }
            TotalSubjectDTO totalSubject = new TotalSubjectDTO()
            {
                HomeSuject = homeSubject,
                TotalCount = result.Count
            };
            return totalSubject;
        }
    }
}