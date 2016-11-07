using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DTO.AutoCodeAttribute;
namespace TCReport.DTO.DBModel
{
    [Table("tc_report_default_preworkcontent")]
    //AutoCreateTime:2016/11/7 11:28:22
    public class db_tc_report_default_preworkcontent
    {
        /// <summary>
        /// Type[bigint(20)] Nullable[False]
        /// </summary>
        [Key]
        [AutoIncrement]
        public long ID { get; set; }

        /// <summary>
        /// Type[varchar(16)] Nullable[False]
        /// </summary>
        public string Report_DefaultUUID { get; set; }

        /// <summary>
        /// Type[varchar(255)] Nullable[False]
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Type[tinyint(4)] Nullable[False]
        /// </summary>
        public int NeedDay { get; set; }

        /// <summary>
        /// Type[decimal(3)] Nullable[False]
        /// </summary>
        public decimal Progress { get; set; }

        /// <summary>
        /// Type[tinyint(4)] Nullable[False]
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Type[tinyint(4)] Nullable[False]
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// Type[varchar(2000)] Nullable[True]
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Type[varchar(2000)] Nullable[True]
        /// </summary>
        public string LeaderRemark { get; set; }

    }
}