using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Administration;
using TO;

namespace BL.Admistration
{
    public class ManagerUserSystem
    {

        public List<BLSystemUser> SystemUserList()
        {
            DAOSystemUser Ds = new DAOSystemUser();
            List<SystemUser> list = Ds.UserList();
            List<BLSystemUser> auxList = new List<BLSystemUser>();
            foreach (SystemUser user in list)
            {
                BLSystemUser auxUser = new BLSystemUser(user.SystemUserName, user.SystemUserPassword, user.SystemUserRole);
                auxList.Add(auxUser);
            }
            return auxList;
        }

        public List<string> ListUserString()
        {
            List<string> stringList = new List<string>();
            List<BLSystemUser> list = SystemUserList();
            string role = "";
            foreach (BLSystemUser user in list)
            {
                if (user.SystemUserRole.Equals("Admin"))
                {
                    role = "Administrator";
                }
                else
                {
                    role = "Kitchen User";
                }
                stringList.Add("UserName: " + user.SystemUserName + " ,Password: " + user.SystemUserPassword + " ,Role: " + role + ".");
            }
            return stringList;
        }

        public String userLogIn(BLSystemUser userSystem)
        {
            DAOSystemUser dsu = new DAOSystemUser();
            SystemUser user = new SystemUser(userSystem.SystemUserName, userSystem.SystemUserPassword, userSystem.SystemUserRole);

            String result = dsu.checkUserCredentials(user);

            return result;
        }

        public void updateUser(BLSystemUser user)
        {
            List<BLSystemUser> list = SystemUserList();
            DAOSystemUser dv = new DAOSystemUser();
            foreach (BLSystemUser item in list)
            {
                if (user.SystemUserName == item.SystemUserName)
                {
                    SystemUser toUser = new SystemUser() { SystemUserName = user.SystemUserName, SystemUserPassword = user.SystemUserPassword, SystemUserRole = user.SystemUserRole };
                    dv.updateUser(toUser);
                    return;
                }

            }

        }

        public bool addUser(BLSystemUser user)
        {
            DAOSystemUser dv = new DAOSystemUser();
            SystemUser toUser = new SystemUser() { SystemUserName = user.SystemUserName, SystemUserPassword = user.SystemUserPassword, SystemUserRole = user.SystemUserRole };
            if (dv.checkNameUser(toUser.SystemUserName))
            {
                dv.addUser(toUser);
                return true;
            }
            return false;

        }

        public void deleteUser(string name)
        {
            DAOSystemUser user = new DAOSystemUser();
            user.DeleteUser(name);
        }

        public BLSystemUser ChargeUser(string code)
        {
            DAOSystemUser dv = new DAOSystemUser();
            if (!dv.checkNameUser(code))
            {
                SystemUser user = dv.ChargeUser(code);
                return new BLSystemUser(user.SystemUserName, user.SystemUserPassword, user.SystemUserRole);
            }
            else
            {
                return null;
            }

        }
    }
}
