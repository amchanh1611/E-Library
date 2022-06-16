namespace E_Library.DTO.Authen
{
    public class UserRoleDTO
    {
        public int UserId { get; set; }
        public string? LoginName { get; set; }
        public int? Password { get; set; }
        public string? UserName { get; set; }
        public int? RoleId { get; set; }
    }
}