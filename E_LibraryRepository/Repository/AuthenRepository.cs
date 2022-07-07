using E_Library.DTO.Authen;
using E_Library.Models;
using E_Library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace E_Library.Repository.Repository
{
    public class AuthenRepository : IAuthenRepository
    {
        private readonly E_LibraryDbContext _context;
        public AuthenRepository(E_LibraryDbContext context)
        {
            _context = context;
        }

        public int CheckTheNumberOTPCreated(int userId, DateTime dateSend)
        {
            return _context.OTPs.Where(w => w.UserId == userId && w.CreateDate==dateSend).Count();

        }

        public bool CreateNewUser(int? password, string? loginName, string? userName)
        {
            var add = _context.Users.Add(new User { UserName=userName, Password=password , LoginName=loginName});
            var check = _context.SaveChanges();
            return check>0?true:false;
        }

        public bool CreateOTP(OTPDTO otp)
        {
            _context.OTPs.Add(new OTP { OTPValue = (otp.OTPValue).ToString(), CreateDate = otp.CreateDate, UserId = otp.UserId });
            var check = _context.SaveChanges();
            return check > 0?true:false;
        }

        public OTP GetOTPByValue(string oTPValue)
        {
            return _context.OTPs.Where(w => w.OTPValue == oTPValue).FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.Where(w => w.Email == email).FirstOrDefault();
        }

        public User GetUserById(int id)
        {
            return _context.Users.Include(i=>i.UserRoles).ThenInclude(t=>t.Role).ThenInclude(a=>a.PermistionRoles).ThenInclude(b=>b.Permisstion).Where(w=>w.UserId==id).FirstOrDefault();
        }

        public User Login(int? password, string? loginName)
        {
            return _context.Users.SingleOrDefault(s=>s.LoginName==loginName && s.Password==password);
        }
        
    }
}