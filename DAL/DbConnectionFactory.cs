using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL
{
    internal static class DbConnectionFactory
    {
        private const string ConnectionStringName = "connStr";

        public static IDbConnection Create()
        {
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings[ConnectionStringName];
            if (connectionStringSettings == null || string.IsNullOrWhiteSpace(connectionStringSettings.ConnectionString))
            {
                throw new InvalidOperationException("未找到数据库连接字符串 connStr。");
            }

            return new SqlConnection(connectionStringSettings.ConnectionString);
        }
    }
}
