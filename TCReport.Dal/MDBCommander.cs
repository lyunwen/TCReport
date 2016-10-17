using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TCReport.DTO.DataBaseAttribute;

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
    public static class IDbConnectionExtention
    {
        public static bool Insert<T>(this IDbConnection cnn, CommandDefinition command) where T : class
        {
            return false;
        }
        private static string GetInsertSql<T>() where T : class
        {
            Type type =  typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            string tableName;
            var tableAttr = type.GetCustomAttribute(typeof(TableAttribute)) as TableAttribute;
            if (tableAttr != null)
            {
                tableName = tableAttr.Name;
            }
            else
            {
                tableName = nameof(T);
            }
            StringBuilder insertSql = new StringBuilder();
            return "";
        }
    }
}

