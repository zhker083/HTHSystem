using System.Data;
using Models;

namespace DAL
{
    public interface IUserDal
    {
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int Register(UserInfo user);
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        int Delete(string account);

        bool Exists(string account);

        UserInfo GetByAccount(string account);

        DataTable GetList();

        UserInfo Login(string account, string password);
    }
}
