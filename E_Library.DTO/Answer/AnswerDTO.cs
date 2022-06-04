namespace E_Library.DTO
{
    public class AnswerDTO
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerName { get; set; }
        public bool CorrectAnswer { get; set; }
    }
}