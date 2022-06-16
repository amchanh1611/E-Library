
using E_Library.DTO.Anthen;

namespace E_Library.DTO.Authen
{
    public class LoginResponeDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}