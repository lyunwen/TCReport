using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.DTO.DataBaseAttribute
{
    public class TableAttribute : Attribute
    {
        private readonly string _name;
        public String Name
        {
            get { return _name; }
        }
        public TableAttribute(string name)
        {
            _name = Name;
        }
    }
}
