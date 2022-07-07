using E_Library.Common.Enum.Author;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("Permisstions")]
    public class Permisstion
    {
        [Key]
        public int PermisstionId { get; set; }
        public Permisstions PermisstionName { get; set; }
        public ICollection<PermistionRole> PermisstionRoles { get; set; }
    }
}