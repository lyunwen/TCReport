using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DB.AutoCodeAttribute;
namespace TCReport.DB.DBModel
{
    [Table("tc_report_default")]
    //AutoCreateTime:2016/11/14 9:32:11
    public class db_tc_report_default
    {
        /// <summary>
        /// Type[bigint(20)] Nullable[False]
        /// </summary>
        [Key]
        [AutoIncrement]
        public long ID { get; set; }

        /// <summary>
        /// Type[varchar(36)] Nullable[False]
        /// </summary>
        public string UUID { get; set; }

        /// <summary>
        /// Type[datetime] Nullable[False]
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Type[varchar(255)] Nullable[False]
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// Type[date] Nullable[False]
        /// </summary>
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Type[date] Nullable[False]
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Type[varchar(500)] Nullable[True]
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Type[varchar(500)] Nullable[True]
        /// </summary>
        public string LeaderRemark { get; set; }

    }
}