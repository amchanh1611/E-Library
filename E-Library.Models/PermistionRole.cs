using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("PermisstionRoles")]
    public class PermistionRole
    {
        public int RoleId { get; set; }
        public int PermisstionId { get; set; }
        public Role Role { get; set; }
        public Permisstion Permisstion { get; set; }
    }
}