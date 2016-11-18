
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Collections.Concurrent;
//using System.Reflection;
//using Dapper;

//namespace Dapper
//{ 
//    public class DapperPocoInfo
//    {
//        private Type _type;
//        private ConcurrentDictionary<string, KeyValuePair<DbType, int>> _stringColumns
//            = new ConcurrentDictionary<string, KeyValuePair<DbType, int>>();
//        private IEnumerable<PropertyInfo> _typeProperties;
//        private IList<PropertyInfo> _keyProperties = new List<PropertyInfo>();
//        private IEnumerable<PropertyInfo> _defaultKeyPropeties;
//        private string _tableName;
//        /// <summary>  
//        /// 对应表名  
//        /// </summary>  
//        public string TableName
//        {
//            get
//            {
//                if (string.IsNullOrWhiteSpace(this._tableName))
//                {
//                    this._tableName = this._type.Name;
//                }
//                return this._tableName;
//            }
//            set
//            {
//                this._tableName = value;
//            }
//        }
//        /// <summary>  
//        /// 所有Public的属性集合  
//        /// </summary>  
//        public IEnumerable<PropertyInfo> TypeProperties
//        {
//            get { return this._typeProperties; }
//        }
//        /// <summary>  
//        /// 获取主键集合，如果主键数量大于1，则认为是联合主键，等于0认为不存在主键，等于1并且类型为数字型则认为自增主键  
//        /// </summary>  
//        /// <returns></returns>  
//        public IEnumerable<PropertyInfo> KeyProperties
//        {
//            get
//            {
//                if (this._keyProperties.Count == 0)
//                {//如果未设定KeyProperties，则默认认为第一个后缀为ID的PropertyInfo为主键  
//                    if (this._defaultKeyPropeties == null)
//                    {
//                        this._defaultKeyPropeties = this._typeProperties.Where(p => p.Name.ToLower().EndsWith("id")).Take(1).ToArray();
//                    }
//                    return this._defaultKeyPropeties;
//                }
//                else
//                {
//                    return this._keyProperties;
//                }
//            }
//        }
//        /// <summary>  
//        /// .oct  
//        /// </summary>  
//        /// <param name="type"></param>  
//        internal DapperPocoInfo(Type type)
//        {
//            if (type == null)
//            {
//                throw new ArgumentNullException();
//            }
//            this._type = type;
//            this._typeProperties = type.GetProperties();
//        }
//        /// <summary>  
//        /// 添加字符串参数化映射  
//        /// </summary>  
//        /// <param name="propertyName">属性名</param>  
//        /// <param name="dbType">必须为AnsiString、AnsiStringFixedLength、String、StringFixedLength</param>  
//        /// <param name="len">值范围为1~8000</param>  
//        public virtual void AddStringColumnMap(string propertyName, DbType dbType = DbType.AnsiString, int len = 50)
//        {
//            this.GetProperty(propertyName);
//            if (len <= 0 || len > 8000)
//            {//长度范围1~8000,此处暂时对应sql，如果其它关系型数据库长度范围与此不一致，可继承修改  
//                throw new ArgumentException("The param len's value must between 1 and 8000.");
//            }
//            if (dbType != DbType.AnsiString && dbType != DbType.AnsiStringFixedLength && dbType != DbType.String && dbType != DbType.StringFixedLength)
//            {
//                return;
//            }
//            this._stringColumns.TryAdd(propertyName, new KeyValuePair<DbType, int>(dbType, len));
//        }
//        /// <summary>  
//        /// 获取字符串映射  
//        /// </summary>  
//        /// <param name="propertyName"></param>  
//        /// <returns></returns>  
//        public KeyValuePair<DbType, int>? GetStringColumnMap(string propertyName)
//        {
//            KeyValuePair<DbType, int> kvp;
//            if (this._stringColumns.TryGetValue(propertyName, out kvp))
//            {
//                return kvp;
//            }
//            return null;
//        }
//        private PropertyInfo GetProperty(string propertyName)
//        {
//            if (string.IsNullOrWhiteSpace(propertyName))
//            {
//                throw new ArgumentNullException("propertyName can not be null or empty value");
//            }
//            PropertyInfo pi = this._typeProperties.Where(p => p.Name.ToLower() == propertyName.ToLower()).FirstOrDefault();
//            if (pi == null)
//            {
//                throw new ArgumentOutOfRangeException(string.Format("The class '{0}' does not contains property '{1}'.", this._type.FullName, propertyName));
//            }
//            return pi;
//        }
//        /// <summary>  
//        /// 添加主键映射  
//        /// </summary>  
//        /// <param name="propertyName"></param>  
//        public void AddKeyMap(string propertyName)
//        {
//            var pi = this.GetProperty(propertyName);
//            if (this._keyProperties.Where(p => p.Name == pi.Name).FirstOrDefault() == null)
//            {
//                this._keyProperties.Add(pi);
//                this._unWriteKey = null;//赋值时取消已经确认的是否可写键值  
//            }
//        }
//        /// <summary>  
//        /// 不需要插入数据的主键类型，除了Guid，其它均认为自增  
//        /// </summary>  
//        private static Type[] UnWriteTypes = { typeof(int), typeof(short), typeof(long), typeof(byte), typeof(Guid) };
//        private bool? _unWriteKey;
//        /// <summary>  
//        /// 主键是否可写  
//        /// </summary>  
//        /// <returns></returns>  
//        public bool IsUnWriteKey()
//        {
//            if (!this._unWriteKey.HasValue)
//            {
//                this._unWriteKey = false;
//                IList<PropertyInfo> keys = this.KeyProperties.ToList();
//                if (keys.Count == 1)
//                {
//                    this._unWriteKey = UnWriteTypes.Contains(keys[0].PropertyType);
//                }
//            }
//            return this._unWriteKey.Value;
//        }
//    }
//    /// <summary>  
//    /// Dapper扩展类  
//    /// </summary>  
//    public static class DapperExtensions
//    {
//        private static ConcurrentDictionary<RuntimeTypeHandle, DapperPocoInfo> PocoInfos
//            = new ConcurrentDictionary<RuntimeTypeHandle, DapperPocoInfo>();
//        /// <summary>  
//        /// 已实现的ISqlAdapter集合  
//        /// </summary>  
//        private static readonly Dictionary<string, ISqlAdapter> AdapterDictionary
//            = new Dictionary<string, ISqlAdapter>() {
//                {"sqlconnection", new MsSqlServerAdapter()}
//            };

//        public static DapperPocoInfo GetPocoInfo<T>()
//            where T : class
//        {
//            return GetPocoInfo(typeof(T));
//        }
//        public static DapperPocoInfo GetPocoInfo(this Type type)
//        {
//            DapperPocoInfo pi;
//            RuntimeTypeHandle hd = type.TypeHandle;
//            if (!PocoInfos.TryGetValue(hd, out pi))
//            {
//                pi = new DapperPocoInfo(type);
//                PocoInfos[hd] = pi;
//            }
//            return pi;
//        }

//        public static ISqlAdapter GetSqlAdapter(this IDbConnection connection)
//        {
//            string name = connection.GetType().Name.ToLower();
//            ISqlAdapter adapter;
//            if (!AdapterDictionary.TryGetValue(name, out adapter))
//            {
//                throw new NotImplementedException(string.Format("Unknow sql connection '{0}'", name));
//            }
//            return adapter;
//        }

//        /// <summary>  
//        /// 新增数据，如果T只有一个主键，且新增的主键为数字，则会将新增的主键赋值给entity相应的字段，如果为多主键，或主键不是数字和Guid,则主键需输入  
//        /// 如果要进行匿名类型新增，因为匿名类型无法赋值，需调用ISqlAdapter的Insert，由数据库新增的主键需自己写方法查询  
//        /// </summary>  
//        /// <typeparam name="T"></typeparam>  
//        /// <param name="connection"></param>  
//        /// <param name="entity"></param>  
//        /// <param name="transaction"></param>  
//        /// <param name="commandTimeout"></param>  
//        /// <returns></returns>  
//        public static bool Insert<T>(this IDbConnection connection, T entity, IDbTransaction transaction = null, int? commandTimeout = null)
//            where T : class
//        {
//            ISqlAdapter adapter = GetSqlAdapter(connection);
//            return adapter.Insert<T>(connection, entity, transaction, commandTimeout);
//        }
//        /// <summary>  
//        /// 更新数据，如果entity为T,则全字段更新，如果为匿名类型，则修改包含的字段，但匿名类型必须包含主键对应的字段  
//        /// </summary>  
//        /// <typeparam name="T"></typeparam>  
//        /// <param name="connection"></param>  
//        /// <param name="entity"></param>  
//        /// <param name="transaction"></param>  
//        /// <param name="commandTimeout"></param>  
//        /// <returns></returns>  
//        public static bool Update<T>(this IDbConnection connection, object entity, IDbTransaction transaction = null, int? commandTimeout = null)
//            where T : class
//        {
//            ISqlAdapter adapter = GetSqlAdapter(connection);
//            return adapter.UpdateByKey<T>(connection, entity, transaction, commandTimeout);
//        }
//        /// <summary>  
//        /// 删除数据，支持匿名，但匿名类型必须包含主键对应的字段  
//        /// </summary>  
//        /// <typeparam name="T"></typeparam>  
//        /// <param name="connection"></param>  
//        /// <param name="param"></param>  
//        /// <param name="transaction"></param>  
//        /// <param name="commandTimeout"></param>  
//        /// <returns></returns>  
//        public static bool DeleteByKey<T>(this IDbConnection connection, object param, IDbTransaction transaction = null, int? commandTimeout = null)
//            where T : class
//        {
//            ISqlAdapter adapter = GetSqlAdapter(connection);
//            return adapter.DeleteByKey<T>(connection, param, transaction, commandTimeout);
//        }
//        /// <summary>  
//        /// 查询数据，支持匿名，但匿名类型必须包含主键对应的字段  
//        /// </summary>  
//        /// <typeparam name="T"></typeparam>  
//        /// <param name="connection"></param>  
//        /// <param name="param"></param>  
//        /// <param name="transaction"></param>  
//        /// <param name="commandTimeout"></param>  
//        /// <returns></returns>  
//        public static T QueryByKey<T>(this IDbConnection connection, object param, IDbTransaction transaction = null, int? commandTimeout = null)
//            where T : class
//        {
//            ISqlAdapter adapter = GetSqlAdapter(connection);
//            return adapter.QueryByKey<T>(connection, param, transaction, commandTimeout);
//        }
//        /// <summary>  
//        /// 获取最后新增的ID值，仅对Indentity有效  
//        /// </summary>  
//        /// <typeparam name="T"></typeparam>  
//        /// <param name="connection"></param>  
//        /// <returns></returns>  
//        public static long GetLastInsertIndentityID<T>(this IDbConnection connection)
//            where T : class
//        {
//            ISqlAdapter adapter = GetSqlAdapter(connection);
//            return adapter.GetLastInsertID<T>(connection);
//        }
//    }

//    public interface ISqlAdapter
//    {
//        string GetFullQueryByKeySql(Type type);
//        string GetFullInsertSql(Type type);
//        string GetFullUpdateByKeySql(Type type);
//        string GetDeleteByKeySql(Type type);
//        bool Insert<T>(IDbConnection connection, object entity, IDbTransaction transaction, int? commandTimeout)
//            where T : class;
//        bool UpdateByKey<T>(IDbConnection connection, object entity, IDbTransaction transaction, int? commandTimeout)
//            where T : class;
//        bool DeleteByKey<T>(IDbConnection connection, object param, IDbTransaction transaction, int? commandTimeout)
//            where T : class;
//        T QueryByKey<T>(IDbConnection connection, object param, IDbTransaction transaction, int? commandTimeout)
//            where T : class;
//        long GetLastInsertID<T>(IDbConnection connection)
//            where T : class;
//    }

//    internal class BasicSql
//    {
//        public string FullQueryByKeySql { get; set; }
//        public string FullInsertSql { get; set; }
//        public string FullUpdateByKeySql { get; set; }
//        public string DeleteByKeySql { get; set; }
//    }

//    public class MsSqlServerAdapter : ISqlAdapter
//    {
//        private static ConcurrentDictionary<RuntimeTypeHandle, BasicSql> BasicSqls
//            = new ConcurrentDictionary<RuntimeTypeHandle, BasicSql>();
//        private static readonly char SqlParameterChar = '@';

//        internal MsSqlServerAdapter() { }

//        private string GetParameterName(PropertyInfo pi)
//        {
//            return string.Format("{0}{1}", SqlParameterChar, pi.Name);
//        }
//        private BasicSql GetBasicSql(Type type)
//        {
//            BasicSql basicSql;
//            RuntimeTypeHandle hd = type.TypeHandle;
//            if (!BasicSqls.TryGetValue(hd, out basicSql))
//            {
//                basicSql = new BasicSql();
//                BasicSqls[hd] = basicSql;
//            }
//            return basicSql;
//        }
//        private void AppendKeyParameter(StringBuilder tmp, IEnumerable<PropertyInfo> keys)
//        {
//            if (keys.Any())
//            {
//                tmp.AppendLine(" WHERE");
//                foreach (PropertyInfo key in keys)
//                {
//                    tmp.Append(key.Name);
//                    tmp.Append("=");
//                    tmp.Append(this.GetParameterName(key));
//                    tmp.Append(" AND ");
//                }
//                tmp.Remove(tmp.Length - 5, 5);
//            }
//        }
//        public string GetFullQueryByKeySql(Type type)
//        {
//            BasicSql basicSql = this.GetBasicSql(type);
//            if (string.IsNullOrEmpty(basicSql.FullQueryByKeySql))
//            {
//                DapperPocoInfo dpi = type.GetPocoInfo();
//                StringBuilder tmp = new StringBuilder();
//                tmp.Append("SELECT * FROM ");
//                tmp.Append(dpi.TableName);
//                tmp.Append(" (NOLOCK) ");
//                this.AppendKeyParameter(tmp, dpi.KeyProperties);
//                basicSql.FullQueryByKeySql = tmp.ToString();
//            }
//            return basicSql.FullQueryByKeySql;
//        }

//        public string GetFullInsertSql(Type type)
//        {
//            BasicSql basicSql = this.GetBasicSql(type);
//            if (string.IsNullOrEmpty(basicSql.FullInsertSql))
//            {
//                DapperPocoInfo dpi = type.GetPocoInfo();
//                basicSql.FullInsertSql = this.GetInsertSql(dpi, dpi.TypeProperties);
//            }
//            return basicSql.FullInsertSql;
//        }

//        private string GetInsertSql(DapperPocoInfo dpi, IEnumerable<PropertyInfo> props)
//        {
//            StringBuilder tmp = new StringBuilder();
//            tmp.Append("INSERT INTO ");
//            tmp.AppendLine(dpi.TableName);
//            tmp.Append('(');

//            IEnumerable<PropertyInfo> valueProps = props;
//            if (dpi.IsUnWriteKey())
//            {
//                valueProps = this.GetExceptProps(props, dpi.KeyProperties);
//            }

//            this.AppendColumnList(tmp, valueProps, '\0');
//            tmp.Append(')');
//            tmp.AppendLine(" VALUES ");
//            tmp.Append('(');
//            this.AppendColumnList(tmp, valueProps, SqlParameterChar);
//            tmp.Append(')');

//            return tmp.ToString();
//        }
//        private void AppendColumnList(StringBuilder tmp, IEnumerable<PropertyInfo> valueProps, char addChar)
//        {
//            foreach (PropertyInfo p in valueProps)
//            {
//                tmp.Append(addChar);
//                tmp.Append(p.Name);
//                tmp.Append(',');
//            }
//            tmp.Remove(tmp.Length - 1, 1);
//        }
//        private IEnumerable<PropertyInfo> GetExceptProps(IEnumerable<PropertyInfo> props1, IEnumerable<PropertyInfo> props2)
//        {
//            //return props1.Except(props2, new EqualityCompareProperty()).ToArray();  
//            IList<PropertyInfo> list = new List<PropertyInfo>();
//            foreach (PropertyInfo pi in props1)
//            {
//                string name = pi.Name.ToLower();
//                if (!props2.Any(p => p.Name.ToLower() == name))
//                {
//                    list.Add(pi);
//                }
//            }
//            return list;
//        }
//        private string GetUpdateSql(DapperPocoInfo dpi, IEnumerable<PropertyInfo> props)
//        {
//            StringBuilder tmp = new StringBuilder();
//            tmp.Append("UPDATE ");
//            tmp.AppendLine(dpi.TableName);
//            tmp.Append("SET ");
//            IEnumerable<PropertyInfo> valueProps = this.GetExceptProps(props, dpi.KeyProperties);
//            foreach (PropertyInfo p in valueProps)
//            {
//                tmp.Append(p.Name);
//                tmp.Append('=');
//                tmp.Append(SqlParameterChar);
//                tmp.Append(p.Name);
//                tmp.Append(',');
//            }
//            tmp.Remove(tmp.Length - 1, 1);
//            tmp.AppendLine();
//            this.AppendKeyParameter(tmp, dpi.KeyProperties);
//            return tmp.ToString();
//        }

//        public string GetFullUpdateByKeySql(Type type)
//        {
//            BasicSql basicSql = this.GetBasicSql(type);
//            if (string.IsNullOrEmpty(basicSql.FullUpdateByKeySql))
//            {
//                DapperPocoInfo dpi = type.GetPocoInfo();
//                basicSql.FullUpdateByKeySql = this.GetUpdateSql(dpi, dpi.TypeProperties);
//            }
//            return basicSql.FullUpdateByKeySql;
//        }

//        public string GetDeleteByKeySql(Type type)
//        {
//            BasicSql basicSql = this.GetBasicSql(type);
//            if (string.IsNullOrEmpty(basicSql.DeleteByKeySql))
//            {
//                DapperPocoInfo dpi = type.GetPocoInfo();
//                StringBuilder tmp = new StringBuilder();
//                tmp.Append("DELETE FROM ");
//                tmp.AppendLine(dpi.TableName);
//                this.AppendKeyParameter(tmp, dpi.KeyProperties);
//                basicSql.DeleteByKeySql = tmp.ToString();
//            }
//            return basicSql.DeleteByKeySql;
//        }

//        public bool Insert<T>(IDbConnection connection, object entity, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
//        {
//            Type type = typeof(T);
//            string insertSql;
//            Type entityType = entity.GetType();
//            DapperPocoInfo dpi = type.GetPocoInfo();
//            if (entityType.IsAssignableFrom(type))
//            {
//                insertSql = this.GetFullInsertSql(type);
//            }
//            else
//            {
//                insertSql = this.GetInsertSql(dpi, entityType.GetProperties());
//            }

//            if (connection.Execute(insertSql, entity, transaction, commandTimeout) > 0)
//            {
//                if (entityType.IsAssignableFrom(type) && dpi.IsUnWriteKey())
//                {
//                    PropertyInfo key = dpi.KeyProperties.First();
//                    if (key.PropertyType != typeof(Guid))
//                    {
//                        var idValue = this.GetLastInsertID(connection, dpi, transaction, commandTimeout);
//                        key.SetValue(entity, idValue, null);
//                    }
//                }
//                return true;
//            }
//            return false;
//        }

//        public bool UpdateByKey<T>(IDbConnection connection, object entity, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
//        {
//            Type type = typeof(T);
//            string updateSql;
//            Type entityType = entity.GetType();
//            DapperPocoInfo dpi = type.GetPocoInfo();
//            if (entityType.IsAssignableFrom(type))
//            {
//                updateSql = this.GetFullUpdateByKeySql(type);
//            }
//            else
//            {
//                updateSql = this.GetUpdateSql(dpi, entityType.GetProperties());
//            }
//            return connection.Execute(updateSql, entity, transaction, commandTimeout) > 0;
//        }

//        public bool DeleteByKey<T>(IDbConnection connection, object param, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
//        {
//            string deleteSql = this.GetDeleteByKeySql(typeof(T));
//            return connection.Execute(deleteSql, param, transaction: transaction, commandTimeout: commandTimeout) > 0;
//        }

//        public T QueryByKey<T>(IDbConnection connection, object param, IDbTransaction transaction = null, int? commandTimeout = null) where T : class
//        {
//            string querySql = this.GetFullQueryByKeySql(typeof(T));
//            return connection.Query<T>(querySql, param, transaction: transaction, commandTimeout: commandTimeout).FirstOrDefault();
//        }

//        private object GetLastInsertID(IDbConnection connection, DapperPocoInfo dpi, IDbTransaction transaction = null, int? commandTimeout = null)
//        {
//            var r = connection.Query("SELECT IDENT_CURRENT('" + dpi.TableName + "') ID", transaction: transaction, commandTimeout: commandTimeout);
//            return Convert.ChangeType(r.First().ID, dpi.KeyProperties.First().PropertyType);
//        }

//        public long GetLastInsertID<T>(IDbConnection connection)
//            where T : class
//        {
//            DapperPocoInfo dpi = typeof(T).GetPocoInfo();
//            return Convert.ToInt64(this.GetLastInsertID(connection, dpi));
//        }
//    }
//}
