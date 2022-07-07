using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? LoginName { get; set; }
        public int? Password { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        [MaxLength(11)]
        public string? SDT { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<OTP> OTPs { get; set; }
    }
}