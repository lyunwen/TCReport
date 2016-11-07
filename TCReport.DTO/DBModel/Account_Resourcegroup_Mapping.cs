using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DTO.AutoCodeAttribute;

namespace TCReport.DTO.DBModel
{
    [Table("account_resourcegroup_mapping")]
    public class Account_ResourceGroup_Mapping
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
        /// ResourceGroupID
        /// </summary>		
        private long _resourcegroupid;
        public long ResourceGroupID
        {
            get { return _resourcegroupid; }
            set { _resourcegroupid = value; }
        }

    }
}

