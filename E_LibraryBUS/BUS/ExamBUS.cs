using E_Library.BUS.IBUS;
using E_Library.DTO.Answer;
using E_Library.DTO.Exam;
using E_Library.DTO.Question;
using E_Library.Repository.IRepository;

namespace E_Library.BUS.BUS
{
    public class ExamBUS : IExamBUS
    {
        private readonly IExamRepository _examRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;

        public ExamBUS(IExamRepository examRepository, ISubjectRepository subjectRepository, IQuestionRepository questionRepository, IAnswerRepository answerRepository)
        {
            _examRepository = examRepository;
            _subjectRepository = subjectRepository;
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
        }

        public List<ExamDTO> FillAndSearchExam(FillAndSearchExamDTO fillAndSearchExam)
        {
            var exams = _examRepository.FillAndSearchExam(fillAndSearchExam.Status, fillAndSearchExam.SubjectId, fillAndSearchExam.TeacherCreateExam, fillAndSearchExam.InfoSearch);
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
            return exams.Select(s => new ExamComboboxTeacherDTO { TeacherCreateExam = s.TeacherCreateExam }).Distinct().ToList();
        }

        public ExamDetailDTO GetExamDetailById(int id)
        {
            var exam = _examRepository.GetExamById(id);
            var questions = _questionRepository.GetAllQuestion();
            var answers = _answerRepository.GetAllAnswers();
            var subjects = _subjectRepository.GetAllSubject();

            //Get list question

            List<QuestionDTO> lstQuestion = questions.Select(s => new QuestionDTO { QuestionCode = s.QuestionCode, QuestionName = s.QuestionName }).ToList();

            //Get list correct answer

            List<AnswerCorrectDTO> lstCorrectAnswer = (from a in answers
                                                       where a.CorrectAnswer == true
                                                       select new AnswerCorrectDTO { QuestionId = a.QuestionId, AnswerCode = a.AnswerCode }).ToList();
            //Get list Answer Default

            List<AnswerDTO> lstAnswerDefault = (from a in answers
                                                where a.QuestionId == 1
                                                select new AnswerDTO { AnswerCode = a.AnswerCode, AnswerName = a.AnswerName, CorrectAnswer = a.CorrectAnswer }).ToList();

            //Create Dictionary QuestionAndAnswer and add Key, Values

            Dictionary<string, string> questionAndAnswer = new Dictionary<string, string>();
            for (int i = 0; i < lstQuestion.Count; i++)
            {
                questionAndAnswer.Add(lstQuestion[i].QuestionCode, lstCorrectAnswer[i].AnswerCode);
            }

            var result = (from e in exam
                        join s in subjects on e.SubjectId equals s.SubjectId
                        select new ExamDetailDTO { SubjectName = s.SubjectName, Time = e.Time, ExamName = e.ExamName, ExamType = e.ExamType, TeacherCreateExam = e.TeacherCreateExam, CreateDate = e.CreateDate, QuestionAndAnswer = questionAndAnswer, QuestionDefault = lstQuestion[0], AnswersDefault = lstAnswerDefault }).FirstOrDefault();

            return result;
        }
    }
}