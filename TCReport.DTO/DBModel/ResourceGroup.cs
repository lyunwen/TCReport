using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DTO.AutoCodeAttribute;

namespace TCReport.DTO.DBModel
{
    [Table("resourcegroup")]
    public class ResourceGroup
    {
        /// <summary>
        /// ID
        /// </summary>		
        private long _id;
        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// ResourceID
        /// </summary>		
        private long _resourceid;
        public long ResourceID
        {
            get { return _resourceid; }
            set { _resourceid = value; }
        }
        /// <summary>
        /// Name
        /// </summary>		
        private long _name;
        public long Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}

