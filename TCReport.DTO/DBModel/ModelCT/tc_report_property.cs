using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using TCReport.DTO.DataBaseAttribute;
namespace TCReport.DTO.DBModel
{
	 	//tc_report_property
		[Table("tc_report_property")]
	public class tc_report_property
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
		/// Name
        /// </summary>		
		private string _name;
        public string Name
        {
            get{ return _name; }
            set{ _name = value; }
        }        
		/// <summary>
		/// Type
        /// </summary>		
		private int _type;
        public int Type
        {
            get{ return _type; }
            set{ _type = value; }
        }        
		/// <summary>
		/// Regx
        /// </summary>		
		private string _regx;
        public string Regx
        {
            get{ return _regx; }
            set{ _regx = value; }
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
		private DateTime _createby;
        public DateTime CreateBy
        {
            get{ return _createby; }
            set{ _createby = value; }
        }        
		/// <summary>
		/// IsValid
        /// </summary>		
		private bool _isvalid;
        public bool IsValid
        {
            get{ return _isvalid; }
            set{ _isvalid = value; }
        }        
		/// <summary>
		/// ReportTypeID
        /// </summary>		
		private long _reporttypeid;
        public long ReportTypeID
        {
            get{ return _reporttypeid; }
            set{ _reporttypeid = value; }
        }        
		 
	}
}