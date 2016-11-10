using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DB.AutoCodeAttribute;
namespace TCReport.DB.DBModel
{
    [Table("tc_reportgroup")]
    //AutoCreateTime:2016/11/10 17:49:17
    public class db_tc_reportgroup
    {
        /// <summary>
        /// Type[bigint(20)] Nullable[False]
        /// </summary>
        [Key]
        [AutoIncrement]
        public long ID { get; set; }

        /// <summary>
        /// Type[bigint(20)] Nullable[False]
        /// </summary>
        public long ParentID { get; set; }

        /// <summary>
        /// Type[varchar(255)] Nullable[False]
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type[bit] Nullable[False]
        /// </summary>
        public bool IsValid { get; set; }

    }
}