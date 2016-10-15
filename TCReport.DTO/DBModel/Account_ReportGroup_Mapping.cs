using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DTO.DataBaseAttribute;
namespace TCReport.DTO.DBModel
{
    [Table("account_reportgroup_mapping")]
    public class Account_ReportGroup_Mapping
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
        /// AccountID
        /// </summary>		
        private long _accountid;
        public long AccountID
        {
            get { return _accountid; }
            set { _accountid = value; }
        }
        /// <summary>
        /// GroupID
        /// </summary>		
        private long _groupid;
        public long GroupID
        {
            get { return _groupid; }
            set { _groupid = value; }
        }

    }
}

