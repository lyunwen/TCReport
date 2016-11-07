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
        /// ColumnName[ID]
        /// </summary>
        [Key]
        [AutoCreate]
        public long ID { get; set; }

        /// <summary>
        /// ColumnName[Role]
        /// </summary>
        public long Role { get; set; }

        /// <summary>
        /// ColumnName[Password]
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// DefaultVal[b'0'] ColumnName[PasswordVerify]
        /// </summary>
        public bool PasswordVerify { get; set; }

        /// <summary>
        /// ColumnName[UserName]
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// DefaultVal[b'0'] ColumnName[UserNameVerify]
        /// </summary>
        public bool UserNameVerify { get; set; }

        /// <summary>
        /// ColumnName[Mobile]
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// DefaultVal[b'0'] ColumnName[MobileVerify]
        /// </summary>
        public bool MobileVerify { get; set; }

        /// <summary>
        /// ColumnName[WechatOpenId]
        /// </summary>
        public string WechatOpenId { get; set; }

        /// <summary>
        /// DefaultVal[b'0'] ColumnName[WechatOpenIdVerify]
        /// </summary>
        public bool WechatOpenIdVerify { get; set; }

        /// <summary>
        /// ColumnName[Email]
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// DefaultVal[b'0'] ColumnName[EmailVerify]
        /// </summary>
        public bool EmailVerify { get; set; }

        /// <summary>
        /// ColumnName[CreateTime]
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// DefaultVal[default] ColumnName[ResgiterIdentify]
        /// </summary>
        public string ResgiterIdentify { get; set; }

    }
}