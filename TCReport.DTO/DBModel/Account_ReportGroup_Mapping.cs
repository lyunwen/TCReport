using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DTO.AutoCodeAttribute;
namespace TCReport.DTO.DBModel
{
    [Table("account_reportgroup_mapping")]
    public class db_account_reportgroup_mapping
    {
        /// <summary>
        /// Type[bigint(20)] Nullable[False]
        /// </summary>
        [Key]
        [AutoCreate]
        public long ID { get; set; }

        /// <summary>
        /// Type[bigint(20)] Nullable[False]
        /// </summary>
        public long AccountID { get; set; }

        /// <summary>
        /// Type[bigint(20)] Nullable[False]
        /// </summary>
        public long GroupID { get; set; }

    }
}