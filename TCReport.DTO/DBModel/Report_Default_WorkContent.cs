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
        private long _report_defaultid;
        private string _content;
        private int _needday;
        private decimal _progress;
        private int _level;
        private int _state;
        private int _type;
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
        public long Report_DefaultID
        {
            set { _report_defaultid = value; }
            get { return _report_defaultid; }
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
        public int Type
        {
            set { _type = value; }
            get { return _type; }
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
