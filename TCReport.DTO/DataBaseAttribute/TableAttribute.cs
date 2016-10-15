using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.DTO.DataBaseAttribute
{
    public class TableAttribute : Attribute
    {
        private readonly string _tableName;
        public TableAttribute(string tableName)
        {
            _tableName = tableName;
        } 
    }
}
