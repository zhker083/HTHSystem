using System;
using System.Data;
using Models;
using UserRepositoryContract = DAL.IUserRepository;
using UserRepositoryImpl = DAL.UserRepository;

namespace BLL
{
    public class UserService : IUserService
    {
        private readonly UserRepositoryContract _userRepository;

        public UserService()
            : this(new UserRepositoryImpl())
        {
        }

        public UserService(UserRepositoryContract userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
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

            if (_userRepository.Exists(user.Account))
            {
                throw new InvalidOperationException("账号已存在。请更换账号后再试。");
            }

            return _userRepository.Register(user);
        }

        public int Delete(string account)
        {
            ValidateAccount(account);
            return _userRepository.Delete(account);
        }

        public bool Exists(string account)
        {
            ValidateAccount(account);
            return _userRepository.Exists(account);
        }

        public UserInfo GetByAccount(string account)
        {
            ValidateAccount(account);
            return _userRepository.GetByAccount(account);
        }

        public DataTable GetList()
        {
            return _userRepository.GetList();
        }

        public UserInfo Login(string account, string password)
        {
            ValidateAccount(account);

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("密码不能为空。", nameof(password));
            }

            return _userRepository.Login(account, password);
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
