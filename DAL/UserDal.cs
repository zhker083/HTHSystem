using System;
using System.Data;
using BCryptNet = BCrypt.Net.BCrypt;
using Dapper;
using Models;

namespace DAL
{
    /// <summary>
    /// 用户数据访问类：负责用户的增删查和登录校验。
    /// </summary>
    public class UserDal : IUserDal
    {
        /// <summary>
        /// 注册用户。
        /// </summary>
        public int Register(UserInfo user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            const string sql = "INSERT INTO [Users](Account, [Password], Permission) VALUES(@Account, @Password, @Permission)";
            string passwordHash = BCryptNet.HashPassword(user.Password);

            using (IDbConnection connection = DbConnectionFactory.Create())
            {
                return connection.Execute(sql, new
                {
                    user.Account,
                    Password = passwordHash,
                    Permission = (int)user.Permission
                });
            }
        }

        /// <summary>
        /// 按账号删除用户。
        /// </summary>
        public int Delete(string account)
        {
            const string sql = "DELETE FROM [Users] WHERE Account=@Account";

            using (IDbConnection connection = DbConnectionFactory.Create())
            {
                return connection.Execute(sql, new { Account = account });
            }
        }

        /// <summary>
        /// 判断账号是否已存在。
        /// </summary>
        public bool Exists(string account)
        {
            const string sql = "SELECT COUNT(1) FROM [Users] WHERE Account=@Account";

            using (IDbConnection connection = DbConnectionFactory.Create())
            {
                return connection.ExecuteScalar<int>(sql, new { Account = account }) > 0;
            }
        }

        /// <summary>
        /// 按账号查询单个用户。
        /// </summary>
        public UserInfo GetByAccount(string account)
        {
            const string sql = "SELECT TOP 1 Account, [Password], Permission FROM [Users] WHERE Account=@Account";

            using (IDbConnection connection = DbConnectionFactory.Create())
            {
                return connection.QueryFirstOrDefault<UserInfo>(sql, new { Account = account });
            }
        }

        /// <summary>
        /// 查询全部用户列表。
        /// </summary>
        public DataTable GetList()
        {
            const string sql = @"SELECT Account,Permission,CASE Permission WHEN 1 THEN N'员工' WHEN 2 THEN N'技术员' WHEN 3 THEN N'工程师' ELSE N'未知' END AS PermissionName FROM [Users] ORDER BY Account";

            using (IDbConnection connection = DbConnectionFactory.Create())
            using (IDataReader reader = connection.ExecuteReader(sql))
            {
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
        }

        /// <summary>
        /// 登录校验：账号+密码匹配返回用户，否则返回 null。
        /// </summary>
        public UserInfo Login(string account, string password)
        {
            const string sql = "SELECT TOP 1 Account, [Password], Permission FROM [Users] WHERE Account=@Account";

            using (IDbConnection connection = DbConnectionFactory.Create())
            {
                UserInfo user = connection.QueryFirstOrDefault<UserInfo>(sql, new
                {
                    Account = account
                });

                if (user == null)
                {
                    return null;
                }

                if (!string.IsNullOrEmpty(user.Password) && BCryptNet.Verify(password, user.Password))
                {
                    return user;
                }

                return null;
            }
        }
    }
}
