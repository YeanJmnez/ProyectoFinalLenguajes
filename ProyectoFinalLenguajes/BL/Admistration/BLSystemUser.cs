using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace BL.Admistration
{
    public class BLSystemUser
    {
        public string SystemUserName { get; set; }
        public string SystemUserPassword { get; set; }
        public string SystemUserRole { get; set; }

        public BLSystemUser() { }

        public BLSystemUser(String name, String password, string role)
        {
            this.SystemUserName = name;
            this.SystemUserPassword = password;
            this.SystemUserRole = role;
        }

    }
}
