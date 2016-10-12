using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.Common
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class RemarkAttribute : Attribute
    {
        public RemarkAttribute(string remark)
        {
            Remark = remark;
        }
        public string Remark { private set; get; }
        public static string GetEnumRemark(Enum val)
        {
            Type type = val.GetType();
            FieldInfo fd = type.GetField(val.ToString());
            if (fd == null)
                return string.Empty;
            object[] attrs = fd.GetCustomAttributes(typeof(RemarkAttribute), false);
            string name = string.Empty;
            foreach (RemarkAttribute attr in attrs)
            {
                name = attr.Remark;
            }
            return name;
        }

        /// <summary>
        /// 获取注释键值对
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns>属性名 描述</returns>
        public static List<KeyValuePair<string, string>> GetNameValueList(Type enumType)
        {
            var keyValues = new List<KeyValuePair<string, string>>();
            Type type = enumType;
            FieldInfo[] fieldInfos = type.GetFields();
            foreach (var fieldInfo in fieldInfos)
            {
                var bar = fieldInfo.GetCustomAttribute(typeof(RemarkAttribute));
                if (bar != null)
                {
                    keyValues.Add(new KeyValuePair<string, string>(fieldInfo.Name, (bar as RemarkAttribute).Remark));
                }
            }
            return keyValues;
        }
          
        /// <summary>
        ///获取枚举值属性
        /// </summary>
        /// <param name="type"></param>
        /// <returns>对应整数 属性名 描述</returns>
        public static List<Tuple<int, string, string>> GetDescriptionAttributes(Type enumType)
        {
            List<Tuple<int, string, string>> result = new List<Tuple<int, string, string>>();
            var memberInfos = enumType.GetMembers();
            foreach (var info in memberInfos)
            {
                var attr = info.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (attr.Length == 1)
                {
                    System.ComponentModel.DescriptionAttribute deAttr = attr[0] as System.ComponentModel.DescriptionAttribute;
                    if (deAttr != null)
                    {
                        result.Add(new Tuple<int, string, string>(((int)Enum.Parse(enumType, info.Name)), info.Name, deAttr.Description));
                    }
                }
            }
            return result;
        }
    }
}
