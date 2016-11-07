using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DTO.AutoCodeAttribute;
namespace TCReport.DTO.DBModel
{
    [Table("resource")]
    public class db_resource
    {
        /// <summary>
        /// Type[bigint(20)] Nullable[False]
        /// </summary>
        [Key]
        [AutoIncrement]
        public long ID { get; set; }

        /// <summary>
        /// Type[varchar(255)] Nullable[False]
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Type[varchar(255)] Nullable[False]
        /// </summary>
        public string CreateBy { get; set; }

    }
}