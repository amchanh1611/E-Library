using E_Library.Models;

namespace E_Library.BUS.IBUS
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);

        public int? ValidateJwtToken(string token);
    }
}