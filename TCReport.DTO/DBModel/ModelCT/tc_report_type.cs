using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using TCReport.DTO.DataBaseAttribute;
namespace TCReport.DTO.DBModel
{
	 	//tc_report_type
		[Table("tc_report_type")]
	public class tc_report_type
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
		private long _createby;
        public long CreateBy
        {
            get{ return _createby; }
            set{ _createby = value; }
        }        
		/// <summary>
		/// Description
        /// </summary>		
		private string _description;
        public string Description
        {
            get{ return _description; }
            set{ _description = value; }
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
		/// Type
        /// </summary>		
		private int _type;
        public int Type
        {
            get{ return _type; }
            set{ _type = value; }
        }        
		 
	}
}