using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DTO.AutoCodeAttribute;

namespace TCReport.DTO.DBModel
{
    [Table("tc_report_group")]
    public class ReportGroup
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
        /// ParentID
        /// </summary>		
        private long _parentid;
        public long ParentID
        {
            get { return _parentid; }
            set { _parentid = value; }
        }
        /// <summary>
        /// Name
        /// </summary>		
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// IsValid
        /// </summary>		
        private bool _isvalid;
        public bool IsValid
        {
            get { return _isvalid; }
            set { _isvalid = value; }
        }

    }
}

