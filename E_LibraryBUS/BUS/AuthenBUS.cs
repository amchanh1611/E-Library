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

        public int ForgotPassword(string email)
        {
            var user = _authenRepository.GetUserByEmail(email);
            if (user == null)
                return 0;
            var lstOTPOfUser = _authenRepository.CheckTheNumberOTPCreated(user.UserId, DateTime.Now);
            if (lstOTPOfUser > 2)
                return 0;
            Random oTP = new Random();
            var oTPValue = oTP.Next(1000, 9999);
            _authenRepository.CreateOTP(new OTPDTO { OTPValue = oTPValue, CreateDate = DateTime.Now, UserId = user.UserId });
            return oTPValue;
        }

        public LoginResponeDTO Login(LoginDTO login)
        {
            var user = _authenRepository.Login(login.Password, login.LoginName);

            if (user == null)
                return null;

            var token = _jwtUtils.GenerateJwtToken(user);
            return new LoginResponeDTO { User = new UserDTO { LoginName = user.LoginName, Password = user.Password, UserName = user.UserName }, Token = token };
        }

        public bool ValidateOTP(string oTP)
        {
            var otp = _authenRepository.GetOTPByValue(oTP);
            var time = DateTime.Now.Subtract(otp.CreateDate);
            if (time.Minutes < 2)
                return true;
            return false;
        }
    }
}