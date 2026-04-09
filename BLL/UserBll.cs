using System;
using System.Data;
using DAL;
using Models;

namespace BLL
{
    public class UserBll : IUserBll
    {
        private readonly IUserDal _userDal;

        public UserBll()
            : this(new UserDal())
        {
        }

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal ?? throw new ArgumentNullException(nameof(userDal));
        }

        public int Register(UserInfo user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (string.IsNullOrWhiteSpace(user.Account))
            {
                throw new ArgumentException("账号不能为空。", nameof(user));
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("密码不能为空。", nameof(user));
            }

            if (_userDal.Exists(user.Account))
            {
                throw new InvalidOperationException("账号已存在。请更换账号后再试。");
            }

            return _userDal.Register(user);
        }

        public int Delete(string account)
        {
            ValidateAccount(account);
            return _userDal.Delete(account);
        }

        public bool Exists(string account)
        {
            ValidateAccount(account);
            return _userDal.Exists(account);
        }

        public UserInfo GetByAccount(string account)
        {
            ValidateAccount(account);
            return _userDal.GetByAccount(account);
        }

        public DataTable GetList()
        {
            return _userDal.GetList();
        }

        public UserInfo Login(string account, string password)
        {
            ValidateAccount(account);

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("密码不能为空。", nameof(password));
            }

            return _userDal.Login(account, password);
        }

        private static void ValidateAccount(string account)
        {
            if (string.IsNullOrWhiteSpace(account))
            {
                throw new ArgumentException("账号不能为空。", nameof(account));
            }
        }
    }
}
