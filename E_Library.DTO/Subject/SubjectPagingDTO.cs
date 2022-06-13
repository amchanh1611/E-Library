namespace E_Library.DTO.Subject
{
    public class SubjectPagingDTO
    {
        public int PageNumber { get; set; }
        public int PageNow { get; set; }
        public List<SubjectDTO> Subject { get; set; }
    }
}