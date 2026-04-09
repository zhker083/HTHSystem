using System;
using System.Data;
using BCryptNet = BCrypt.Net.BCrypt;
using Dapper;
using Models;

namespace DAL
{
    public class UserRepository : IUserRepository
    {
        public int Register(UserInfo user)
        {
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
        public int Delete(string account)
        {
            const string sql = "DELETE FROM [Users] WHERE Account=@Account";

            using (IDbConnection connection = DbConnectionFactory.Create())
            {
                return connection.Execute(sql, new { Account = account });
            }
        }
        public bool Exists(string account)
        {
            const string sql = "SELECT COUNT(1) FROM [Users] WHERE Account=@Account";

            using (IDbConnection connection = DbConnectionFactory.Create())
            {
                return connection.ExecuteScalar<int>(sql, new { Account = account }) > 0;
            }
        }
        public UserInfo GetByAccount(string account)
        {
            const string sql = "SELECT TOP 1 Account, [Password], Permission FROM [Users] WHERE Account=@Account";

            using (IDbConnection connection = DbConnectionFactory.Create())
            {
                return connection.QueryFirstOrDefault<UserInfo>(sql, new { Account = account });
            }
        }
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
