using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.DTO.DBModel
{
    public class ReportData
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
        /// ReportInstanceID
        /// </summary>		
        private long _reportinstanceid;
        public long ReportInstanceID
        {
            get { return _reportinstanceid; }
            set { _reportinstanceid = value; }
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
        /// Value
        /// </summary>		
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

    }
}
