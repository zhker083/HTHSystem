using System.Data;
using Models;

namespace DAL
{
    public interface IUserRepository
    {
        int Register(UserInfo user);
        int Delete(string account);
        bool Exists(string account);
        UserInfo GetByAccount(string account);
        DataTable GetList();
        UserInfo Login(string account, string password);
    }
}
