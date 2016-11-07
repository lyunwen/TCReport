using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using TCReport.DTO.AutoCodeAttribute;
namespace TCReport.DTO.DBModel
{
    [Table("account")]
    public class db_account
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
        public long Role { get; set; }

        /// <summary>
        /// Type[varchar(50)] Nullable[True]
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Type[bit] Nullable[False] DefaultVal[b'0']
        /// </summary>
        public bool PasswordVerify { get; set; }

        /// <summary>
        /// Type[varchar(50)] Nullable[True]
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Type[bit] Nullable[False] DefaultVal[b'0']
        /// </summary>
        public bool UserNameVerify { get; set; }

        /// <summary>
        /// Type[varchar(20)] Nullable[True]
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Type[bit] Nullable[False] DefaultVal[b'0']
        /// </summary>
        public bool MobileVerify { get; set; }

        /// <summary>
        /// Type[varchar(50)] Nullable[True]
        /// </summary>
        public string WechatOpenId { get; set; }

        /// <summary>
        /// Type[bit] Nullable[False] DefaultVal[b'0']
        /// </summary>
        public bool WechatOpenIdVerify { get; set; }

        /// <summary>
        /// Type[varchar(50)] Nullable[True]
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Type[bit] Nullable[False] DefaultVal[b'0']
        /// </summary>
        public bool EmailVerify { get; set; }

        /// <summary>
        /// Type[datetime] Nullable[True]
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Type[varchar(50)] Nullable[False] DefaultVal[default]
        /// </summary>
        public string ResgiterIdentify { get; set; }

    }
}