using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks; 

namespace TCReport.Dal
{
    public class MDBCommander
    {
        //配置mysql 数据源
        private const string _SqlConnectionString = @"Server=localhost;Port=3306;Database=tcreport;Uid=root;Pwd=;";
        internal static IDbConnection Open()
        {
            MySqlConnection conn = new MySqlConnection(_SqlConnectionString);
            conn.Open();
            return conn;
        }
        internal static int OpenAndExecute(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (var conn = Open())
            {
                return conn.Execute(sql, param, transaction, commandTimeout, commandType);
            }
        }
    }
}

