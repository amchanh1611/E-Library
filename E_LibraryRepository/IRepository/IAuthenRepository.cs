using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IAuthenRepository
    {
        public bool CreateNewUser(int? password, string? loginName, string? userName);
        public User Login(int? password, string? loginName);
        public User GetUserById(int id);    
    }
}