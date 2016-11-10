using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCReport.DB.DBModel;

namespace TCReport.Dal.BOModel
{
    public class Report_DefaultBO
    {
        #region Report_Default 
        private long _id;
        private string _uuid;
        private DateTime _createtime;
        private long _createby;
        private DateTime _begindate;
        private DateTime _enddate;
        private string _remark;
        private string _leaderremark;
        /// <summary>
        /// auto_increment
        /// </summary>
        public long ID
        {
            set { _id = value; }
            get { return _id; }
        }
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public long CreateBy
        {
            set { _createby = value; }
            get { return _createby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BeginDate
        {
            set { _begindate = value; }
            get { return _begindate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate
        {
            set { _enddate = value; }
            get { return _enddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LeaderRemark
        {
            set { _leaderremark = value; }
            get { return _leaderremark; }
        }
        #endregion

        public IList<Report_Default_WorkContent> WorkContents { get; set; }
    }
}