namespace E_Library.DTO.Subject
{
    public class SubjectDTO
    {
        public string? SubjectCode { get; set; }
        public string? SubjectName { get; set; }
        public string? TeacherName { get; set; }
        public string? DocumentWaitAprrove { get; set; }
        public bool? StatusDocumentSubject { get; set; }
        public DateTime? DateAprrove { get; set; }
    }
}