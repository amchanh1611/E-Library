using E_Library.DTO.Anthen;
using E_Library.DTO.Authen;

namespace E_Library.BUS.IBUS
{
    public interface IAuthenBUS
    {
        public bool CreateNewUser(UserDTO infoUser);

        public LoginResponeDTO Login(LoginDTO login);
        public UserRoleDTO GetUserById(int id);
    }
}