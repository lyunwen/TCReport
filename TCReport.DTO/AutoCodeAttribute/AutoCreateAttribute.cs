using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.DB.AutoCodeAttribute
{
    /// <summary>
    /// 自增特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =false,Inherited =true)]
    public class AutoIncrementAttribute : NOInsertAttribute
    {

    }
}
