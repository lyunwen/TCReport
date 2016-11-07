using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TCReport.DTO.AutoCodeAttribute;

namespace TCReport.AutoSql
{
    public static class AutoSqlBuilder<T> where T : class
    {
        public static string ToUpdateSql()
        {
            throw new NotImplementedException();
        }
        public static string BuildInsertSql()
        {
            Type entityType = typeof(T);
            StringBuilder entityInsertSql = new StringBuilder();
            PropertyInfo[] properties = entityType.GetProperties();
            string tableName;
            var tableAttr = entityType.GetCustomAttribute(typeof(TableAttribute)) as TableAttribute;
            if (tableAttr == null)
            {
                tableName = nameof(T);
            }
            else
            {
                tableName = tableAttr.Name;
            }
            entityInsertSql.AppendFormat("INSERT INTO {0} (", tableName);
            var first = true;
            foreach (var item in properties)
            {
                var noInsertAttr = item.GetCustomAttribute(typeof(NOInsertAttribute), true);
                if (noInsertAttr == null)
                {
                    if (first)
                    {
                        entityInsertSql.AppendFormat("{0}", item.Name);
                        first = false;
                    }
                    else
                    {
                        entityInsertSql.AppendFormat(",{0}", item.Name);
                    }
                }
            }
            first = true;
            entityInsertSql.Append(")VALUES(");
            foreach (var item in properties)
            {
                var noInsertAttr = item.GetCustomAttribute(typeof(NOInsertAttribute), true);
                if (noInsertAttr == null)
                {
                    if (first)
                    {
                        entityInsertSql.AppendFormat("@{0}", item.Name);
                        first = false;
                    }
                    else
                    {
                        entityInsertSql.AppendFormat(",@{0}", item.Name);
                    }
                }
            }
            entityInsertSql.Append(")");
            return entityInsertSql.ToString();
        }
        public static string BuildExistSql(string wheres)
        {
            Type entityType = typeof(T);

            #region tableName
            string tableName;
            var tableAttr = entityType.GetCustomAttribute(typeof(TableAttribute)) as TableAttribute;
            if (tableAttr == null)
            {
                tableName = nameof(T);
            }
            else
            {
                tableName = tableAttr.Name;
            }
            #endregion 

            PropertyInfo[] properties = entityType.GetProperties();
            foreach (var item in properties)
            {
                var keyAttr = item.GetCustomAttribute(typeof(KeyAttribute));
                if (keyAttr != null)
                {
                    return string.Format("SELECT {0} FROM {1} WHERE {2}", item.Name, tableName, wheres);
                }
            }
            throw new ArgumentException("No key");
        }
        public static string BuildGetSql(string wheres)
        {
            Type entityType = typeof(T);
            string tableName;
            var tableAttr = entityType.GetCustomAttribute(typeof(TableAttribute)) as TableAttribute;
            if (tableAttr == null)
            {
                tableName = nameof(T);
            }
            else
            {
                tableName = tableAttr.Name;
            }
            return string.Format("SELECT * FROM {0} WHERE {1}", tableName, wheres);
        }
    }
}