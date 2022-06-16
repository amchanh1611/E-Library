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

        public bool CreateNewUser(int? password, string? loginName, string? userName)
        {
            var add = _context.Users.Add(new User { UserName=userName, Password=password , LoginName=loginName});
            var check = _context.SaveChanges();
            return check>0?true:false;
        }

        public User GetUserById(int id)
        {
            return _context.Users.Include(i=>i.UserRoles).ThenInclude(t=>t.Role).Where(w=>w.UserId==id).FirstOrDefault();
        }

        public User Login(int? password, string? loginName)
        {
            return _context.Users.SingleOrDefault(s=>s.LoginName==loginName && s.Password==password);
        }
    }
}