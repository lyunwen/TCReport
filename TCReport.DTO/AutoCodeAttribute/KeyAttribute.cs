﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.DB.AutoCodeAttribute
{
    /// <summary>
    /// 主键特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = false, Inherited = true)]
    public class KeyAttribute:Attribute
    {
        public KeyAttribute()
        { 
            //test0704
        }
    }
}
