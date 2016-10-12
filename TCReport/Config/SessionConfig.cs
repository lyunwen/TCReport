using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.Config
{
    public class SessionConfig
    {
        public static SessionConfig Factory { get; private set; }
        static SessionConfig()
        {
            Factory = new SessionConfig();
        }
        private SessionConfig()
        {
            PropertyInfo[] properties = typeof(SessionConfig).GetProperties();
            foreach (var item in properties)
            {
                if (item.CanWrite && item.PropertyType == typeof(string))
                {
                    item.SetValue(this, Guid.NewGuid().ToString().Replace("-", string.Empty), null);
                }
            }
        }

        /// <summary>
        /// 项目登陆者
        /// </summary>
        public static string TCReposrt_User { private set; get; }

    }
}
