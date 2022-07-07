using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    [Table("OTPs")]
    public class OTP
    {
        [Key]
        public int OTPId { get; set; }
        [MaxLength(4)]
        public string OTPValue { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}