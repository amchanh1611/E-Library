using E_Library.BUS.IBUS;
using E_Library.DTO.Anthen;
using E_Library.DTO.Authen;
using E_Library.Repository.IRepository;

namespace E_Library.BUS.BUS
{
    public class AuthenBUS : IAuthenBUS
    {
        private readonly IAuthenRepository _authenRepository;
        private readonly IJwtUtils _jwtUtils;

        public AuthenBUS(IAuthenRepository authenRepository, IJwtUtils jwtUtils)
        {
            _authenRepository = authenRepository;
            _jwtUtils = jwtUtils;
        }

        public bool CreateNewUser(UserDTO infoUser)
        {
            return _authenRepository.CreateNewUser(infoUser.Password, infoUser.LoginName, infoUser.UserName);
        }

        public UserRoleDTO GetUserById(int id)
        {
            var user = _authenRepository.GetUserById(id);
            return new UserRoleDTO { LoginName = user.LoginName, UserName = user.UserName,Password=user.Password,UserId=user.UserId,RoleId=user.UserRoles.Select(s=>s.RoleId).First() };
        }

        public LoginResponeDTO Login(LoginDTO login)
        {
            var user = _authenRepository.Login(login.Password,login.LoginName);
            var token = _jwtUtils.GenerateJwtToken(user);
            return new LoginResponeDTO { User = new UserDTO { LoginName = user.LoginName, Password = user.Password,UserName=user.UserName },Token = token};
        }
    }
}