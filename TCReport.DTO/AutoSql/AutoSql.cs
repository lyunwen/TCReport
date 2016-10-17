using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TCReport.DTO.AutoSql.AutoCodeAttribute;

namespace TCReport.AutoSql
{
    public static class AutoSql<T> where T : class
    {
        public static string ToInsertSql()
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
        public static string ToExistSql(string wheres)
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
                    return string.Format("SELECT {0} FROM {1} WHERE 1=1 AND {2}", item.Name, tableName, wheres);
                }
            }
            throw new ArgumentException("No key");
        }
        public static string ToGetSql(string wheres)
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
