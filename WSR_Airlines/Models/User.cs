using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_Airlines.Models
{
    class User
    {
        public static int UserId { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static string Firstname { get; set; }
        public static string Secondname { get; set; }
        public static string Birthdate { get; set; }
        public static string Active { get; set; }
        public static int RoleId { get; set; }
        public static int OfficeId { get; set; }


        public User(string _email, string _password, string _firstname,
            string _secondname, string _birthdate, string _active, int _roleId, int _officeId)
        {
            Email = _email;
            Password = _password;
            Firstname = _firstname;
            Secondname = _secondname;
            Birthdate = _birthdate;
            Active = _active;
            RoleId = _roleId;
            OfficeId = _officeId;
        }

    }
}
