using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace TCReport.DTO.DBModel
{
    public class Account
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
        /// Role
        /// </summary>		
        private long _role;
        public long Role
        {
            get { return _role; }
            set { _role = value; }
        }
        /// <summary>
        /// Password
        /// </summary>		
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        /// <summary>
        /// PasswordVerify
        /// </summary>		
        private bool _passwordverify;
        public bool PasswordVerify
        {
            get { return _passwordverify; }
            set { _passwordverify = value; }
        }
        /// <summary>
        /// UserName
        /// </summary>		
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// UserNameVerify
        /// </summary>		
        private bool _usernameverify;
        public bool UserNameVerify
        {
            get { return _usernameverify; }
            set { _usernameverify = value; }
        }
        /// <summary>
        /// Mobile
        /// </summary>		
        private string _mobile;
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        /// <summary>
        /// MobileVerify
        /// </summary>		
        private bool _mobileverify;
        public bool MobileVerify
        {
            get { return _mobileverify; }
            set { _mobileverify = value; }
        }
        /// <summary>
        /// WechatOpenId
        /// </summary>		
        private string _wechatopenid;
        public string WechatOpenId
        {
            get { return _wechatopenid; }
            set { _wechatopenid = value; }
        }
        /// <summary>
        /// WechatOpenIdVerify
        /// </summary>		
        private bool _wechatopenidverify;
        public bool WechatOpenIdVerify
        {
            get { return _wechatopenidverify; }
            set { _wechatopenidverify = value; }
        }
        /// <summary>
        /// Email
        /// </summary>		
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        /// <summary>
        /// EmailVerify
        /// </summary>		
        private bool _emailverify;
        public bool EmailVerify
        {
            get { return _emailverify; }
            set { _emailverify = value; }
        }
        /// <summary>
        /// CreateTime
        /// </summary>		
        private DateTime _createtime;
        public DateTime CreateTime
        {
            get { return _createtime; }
            set { _createtime = value; }
        }
        /// <summary>
        /// ResgiterIdentify
        /// </summary>		
        private string _resgiteridentify;
        public string ResgiterIdentify
        {
            get { return _resgiteridentify; }
            set { _resgiteridentify = value; }
        }

    }
}

