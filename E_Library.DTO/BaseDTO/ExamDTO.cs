namespace E_Library.DTO
{
    public class ExamDTO
    {
        public byte TypeFile { get; set; }

        public string ExamName { get; set; }

        public int SubjectId { get; set; }

        public string TeacherCreateExam { get; set; }

        public bool ExamType { get; set; }

        public byte Time { get; set; }

        public byte Status { get; set; }

        public byte Approve { get; set; }

        public DateTime CreateDate { get; set; }
    }
}