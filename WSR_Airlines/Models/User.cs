using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_Airlines.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Birthdate { get; set; }
        public string Active { get; set; }
        public int RoleId { get; set; }
        public int OfficeId { get; set; }

        public User() { }


        public User(int _userId, string _email, string _password, string _firstname,
            string _secondname, string _birthdate, string _active, int _roleId, int _officeId)
        {
            UserId = _userId;
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
