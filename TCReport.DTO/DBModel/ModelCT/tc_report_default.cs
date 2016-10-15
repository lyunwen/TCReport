using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using TCReport.DTO.DataBaseAttribute;
namespace TCReport.DTO.DBModel
{
	 	//tc_report_default
		[Table("tc_report_default")]
	public class tc_report_default
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
		/// UUID
        /// </summary>		
		private string _uuid;
        public string UUID
        {
            get{ return _uuid; }
            set{ _uuid = value; }
        }        
		/// <summary>
		/// CreateTime
        /// </summary>		
		private DateTime _createtime;
        public DateTime CreateTime
        {
            get{ return _createtime; }
            set{ _createtime = value; }
        }        
		/// <summary>
		/// CreateBy
        /// </summary>		
		private string _createby;
        public string CreateBy
        {
            get{ return _createby; }
            set{ _createby = value; }
        }        
		/// <summary>
		/// BeginDate
        /// </summary>		
		private DateTime _begindate;
        public DateTime BeginDate
        {
            get{ return _begindate; }
            set{ _begindate = value; }
        }        
		/// <summary>
		/// EndDate
        /// </summary>		
		private DateTime _enddate;
        public DateTime EndDate
        {
            get{ return _enddate; }
            set{ _enddate = value; }
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