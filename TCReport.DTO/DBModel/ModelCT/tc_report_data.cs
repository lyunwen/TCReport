using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using TCReport.DTO.DataBaseAttribute;
namespace TCReport.DTO.DBModel
{
	 	//tc_report_data
		[Table("tc_report_data")]
	public class tc_report_data
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
		/// ReportInstanceID
        /// </summary>		
		private long _reportinstanceid;
        public long ReportInstanceID
        {
            get{ return _reportinstanceid; }
            set{ _reportinstanceid = value; }
        }        
		/// <summary>
		/// ReportPropertyID
        /// </summary>		
		private long _reportpropertyid;
        public long ReportPropertyID
        {
            get{ return _reportpropertyid; }
            set{ _reportpropertyid = value; }
        }        
		/// <summary>
		/// Value
        /// </summary>		
		private string _value;
        public string Value
        {
            get{ return _value; }
            set{ _value = value; }
        }        
		 
	}
}