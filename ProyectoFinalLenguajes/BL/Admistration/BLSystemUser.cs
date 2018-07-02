using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DAO.Administration;
using TAO;

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

        public List<SystemUser> SystemUserList()
        {
            DAOSystemUser Ds = new DAOSystemUser();
            List<SystemUser> list = Ds.UserList();
            foreach (SystemUser user in list)
            {
                SystemUser auxUser = new SystemUser(user.SystemUserName, user.SystemUserPassword, user.SystemUserRole);
                list.Add(auxUser);
            }
            return list;
        }

        public String userLogIn()
        {
            DAOSystemUser dsu = new DAOSystemUser();
            SystemUser user = new SystemUser(this.SystemUserName, this.SystemUserPassword, this.SystemUserRole);

            String result = dsu.checkUserCredentials(user);

            return result;
        }

        public void updateUser(SystemUser user)
        {
            List<SystemUser> list = SystemUserList();
            DAOSystemUser dv = new DAOSystemUser();
            foreach (SystemUser item in list)
            {
                if (user.SystemUserName == item.SystemUserName)
                {
                    SystemUser toUser = new SystemUser() { SystemUserName = user.SystemUserName, SystemUserPassword = user.SystemUserPassword, SystemUserRole = user.SystemUserRole };
                    dv.updateUser(toUser);
                    return;
                }

            }

        }

        public void addDish(BLSystemUser user)
        {
            DAOSystemUser dv = new DAOSystemUser();
            SystemUser toUser= new SystemUser() { SystemUserName = user.SystemUserName, SystemUserPassword = user.SystemUserPassword, SystemUserRole = user.SystemUserRole };
            dv.addUser(toUser);
        }

        public void deleteUser(string name)
        {
            DAOSystemUser user = new DAOSystemUser();
            user.DeleteUser(name);
        }

        public BLSystemUser ChargeUser(string code)
        {
            DAOSystemUser dv = new DAOSystemUser();
            SystemUser user = dv.ChargeUser(code);
            return new BLSystemUser(user.SystemUserName, user.SystemUserPassword, user.SystemUserRole);
        }
    }
}
