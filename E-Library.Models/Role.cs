using E_Library.Common.Enum.Author;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public Roles? RoleName { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}