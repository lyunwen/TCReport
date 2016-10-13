using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCReport.DTO.DBModel;

namespace TCReport.DTO.BOModel
{
    public class Report_DefaultBO
    {
        private long _id;
        private DateTime _createtime;
        private string _createby;
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
        public string CreateBy
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

        public IList<Report_Default_WorkContent> WorkContents { get; set; }
        public IList<Report_Default_PreWorkContent> PreWorkContents { get; set; }
    }
}