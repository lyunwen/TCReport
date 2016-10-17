using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DTO.AutoSql.AutoCodeAttribute;

namespace TCReport.DTO.DBModel
{
    [Table("resource")]
    public class Resource
    {
        /// <summary>
        /// auto_increment
        /// </summary>		
        private long _id;
        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// Value
        /// </summary>		
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        /// <summary>
        /// CreateBy
        /// </summary>		
        private string _createby;
        public string CreateBy
        {
            get { return _createby; }
            set { _createby = value; }
        }

    }
}

