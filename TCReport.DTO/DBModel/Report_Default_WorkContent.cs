using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.DTO.DBModel
{
    /// <summary>
    /// Report_Default_WorkContent。
    /// </summary> 
    public partial class Report_Default_WorkContent
    {
        private long _id;
        private string _report_defaultuuid;
        private string _content;
        private int _needday;
        private decimal _progress;
        private int _level;
        private int _state; 
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
        public string Report_DefaultUUID
        {
            set { _report_defaultuuid = value; }
            get { return _report_defaultuuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int NeedDay
        {
            set { _needday = value; }
            get { return _needday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Progress
        {
            set { _progress = value; }
            get { return _progress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Level
        {
            set { _level = value; }
            get { return _level; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
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
    }
} 
