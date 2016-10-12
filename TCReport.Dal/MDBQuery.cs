using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace TCReport.Dal
{
    public class MDBQuery
    {
        //配置mysql 数据源
        private const string _SqlConnectionString = @"Server=localhost;Port=3306;Database=tcreport;Uid=root;Pwd=;";
        internal static IDbConnection Open()
        {
            MySqlConnection conn = new MySqlConnection(_SqlConnectionString);
            conn.Open();
            return conn;
        }
        internal static IEnumerable<T> OpenAndQuery<T>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (var conn = Open())
            {
                return conn.Query<T>(sql, param, transaction, buffered, commandTimeout, commandType);
            }
        }
    }
}
