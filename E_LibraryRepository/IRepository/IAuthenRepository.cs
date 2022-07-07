using E_Library.DTO.Authen;
using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IAuthenRepository
    {
        public bool CreateNewUser(int? password, string? loginName, string? userName);
        public User Login(int? password, string? loginName);
        public User GetUserById(int id);    
        public User GetUserByEmail(string email);
        public bool CreateOTP(OTPDTO otp);
        public int CheckTheNumberOTPCreated(int userId, DateTime dateSend);
        public OTP GetOTPByValue(string oTPValue);
    }
}