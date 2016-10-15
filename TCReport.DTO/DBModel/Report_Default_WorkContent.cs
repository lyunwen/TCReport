using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using TCReport.DTO.DataBaseAttribute;
namespace TCReport.DTO.DBModel
{
	 	//tc_report_default_workcontent
		[Table("tc_report_default_workcontent")]
	public class Report_Default_WorkContent
	{   
      	/// <summary>
		/// auto_increment
        /// </summary>		
		private long _id;
        public long ID
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// Report_DefaultUUID
        /// </summary>		
		private string _report_defaultuuid;
        public string Report_DefaultUUID
        {
            get{ return _report_defaultuuid; }
            set{ _report_defaultuuid = value; }
        }        
		/// <summary>
		/// Content
        /// </summary>		
		private string _content;
        public string Content
        {
            get{ return _content; }
            set{ _content = value; }
        }        
		/// <summary>
		/// NeedDay
        /// </summary>		
		private int _needday;
        public int NeedDay
        {
            get{ return _needday; }
            set{ _needday = value; }
        }        
		/// <summary>
		/// Progress
        /// </summary>		
		private decimal _progress;
        public decimal Progress
        {
            get{ return _progress; }
            set{ _progress = value; }
        }        
		/// <summary>
		/// Level
        /// </summary>		
		private int _level;
        public int Level
        {
            get{ return _level; }
            set{ _level = value; }
        }        
		/// <summary>
		/// State
        /// </summary>		
		private int _state;
        public int State
        {
            get{ return _state; }
            set{ _state = value; }
        }        
		/// <summary>
		/// Remark
        /// </summary>		
		private string _remark;
        public string Remark
        {
            get{ return _remark; }
            set{ _remark = value; }
        }        
		/// <summary>
		/// LeaderRemark
        /// </summary>		
		private string _leaderremark;
        public string LeaderRemark
        {
            get{ return _leaderremark; }
            set{ _leaderremark = value; }
        }        
		 
	}
}