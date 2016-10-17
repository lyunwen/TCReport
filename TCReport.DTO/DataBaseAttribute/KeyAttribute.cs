using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.DTO.DataBaseAttribute
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = false, Inherited = true)]
    public class KeyAttribute:Attribute
    {
        public KeyAttribute()
        {

        }

    }
}
