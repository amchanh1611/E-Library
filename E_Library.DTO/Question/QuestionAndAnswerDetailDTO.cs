using E_Library.DTO.Answer;

namespace E_Library.DTO.Question
{
    public class QuestionAndAnswerDetailDTO
    {
        public QuestionDTO QuestionDetail { get; set; }
        public List<AnswerDTO> AnswerDetail { get; set; }
    }
}