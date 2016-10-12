using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.Dal.DBModel
{
    public class ReportInstance
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
        /// Name
        /// </summary>		
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// ReportPropertyID
        /// </summary>		
        private long _reportpropertyid;
        public long ReportPropertyID
        {
            get { return _reportpropertyid; }
            set { _reportpropertyid = value; }
        }
        /// <summary>
        /// ReportTypeID
        /// </summary>		
        private long _reporttypeid;
        public long ReportTypeID
        {
            get { return _reporttypeid; }
            set { _reporttypeid = value; }
        }
        /// <summary>
        /// CreateBy
        /// </summary>		
        private long _createby;
        public long CreateBy
        {
            get { return _createby; }
            set { _createby = value; }
        }
        /// <summary>
        /// CreateTime
        /// </summary>		
        private long _createtime;
        public long CreateTime
        {
            get { return _createtime; }
            set { _createtime = value; }
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
        /// <summary>
        /// LastEditTime
        /// </summary>		
        private DateTime _lastedittime;
        public DateTime LastEditTime
        {
            get { return _lastedittime; }
            set { _lastedittime = value; }
        }

    }
}
