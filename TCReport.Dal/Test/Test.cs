using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCReport.Dal.Test
{
    public class User
    {
        public User()
        {
            Role = new List<Role>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsFirstTimeLogin { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
        public List<Role> Role { get; set; }
    }
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
    public class Customer
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsFirstTimeLogin { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
        public Role Role { get; set; }
    }

    public class Foo
    {

        private static void OneToMany(string sqlConnectionString)
        {
            Console.WriteLine("One To Many");
            List<User> userList = new List<User>();

            using (IDbConnection connection = GetSqlConnection(sqlConnectionString))
            {

                string sqlCommandText3 = @"SELECT c.UserId,
       c.Username      AS UserName,
       c.PasswordHash  AS [Password],
       c.Email,
       c.PhoneNumber,
       c.IsFirstTimeLogin,
       c.AccessFailedCount,
       c.CreationDate,
       c.IsActive,
       r.RoleId,
       r.RoleName
FROM   dbo.CICUser c WITH(NOLOCK)
       LEFT JOIN CICUserRole cr
            ON  cr.UserId = c.UserId
       LEFT JOIN CICRole r
            ON  r.RoleId = cr.RoleId";

                var lookUp = new Dictionary<int, User>();
                userList = connection.Query<User, Role, User>(sqlCommandText3,
                    (user, role) =>
                    {
                        User u;
                        if (!lookUp.TryGetValue(user.UserId, out u))
                        {
                            lookUp.Add(user.UserId, u = user);
                        }
                        u.Role.Add(role);
                        return user;
                    }, null, null, true, "RoleId", null, null).ToList();
                var result = lookUp.Values;
            }

            if (userList.Count > 0)
            {
                userList.ForEach((item) => Console.WriteLine("UserName:" + item.UserName +
                                             "----Password:" + item.Password +
                                             "-----Role:" + item.Role.First().RoleName +
                                             "\n"));

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No Data In UserList!");
            }
        }
    }
}
