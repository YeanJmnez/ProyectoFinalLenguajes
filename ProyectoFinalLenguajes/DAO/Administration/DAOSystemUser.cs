using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;

namespace DAO.Administration
{
  public class DAOSystemUser
    {

        public String checkUserCredentials(SystemUser su)
        {
            String result = "";

            SystemUser suFound = null;

            using (DB_Project db = new DB_Project())
            {
                suFound = db.SystemUser.Find(su.SystemUserName);

                if (suFound != null)
                {
                    if (suFound.SystemUserPassword.Equals(su.SystemUserPassword))
                    {
                        if (suFound.SystemUserRole.Equals(su.SystemUserRole))
                        {
                            result = "Correct";
                        }
                        else
                        {
                            result = "IncorrectRole";
                        }
                    }
                    else
                    {
                        result = "IncorrectPassword";
                    }
                }
                else
                {
                    result = "IncorrectUserName";
                }
            }            

            return result;
        }

        public List<SystemUser> UserList()
        {
            List<SystemUser> systemUser = new List<SystemUser>();
            using (DB_Project db = new DB_Project())
            {
                systemUser = db.SystemUser.ToList();
            }
            return systemUser;
        }

        public void updateUser(SystemUser systemUser)
        {
            try
            {
                using (DB_Project db = new DB_Project())
                {
                    SystemUser User = db.SystemUser.Find(systemUser.SystemUserName);
                    if (User != null)
                    {
                        User.SystemUserPassword = systemUser.SystemUserPassword;
                        User.SystemUserRole = systemUser.SystemUserRole;
                        db.SaveChanges();
                    }

                }
            }
            catch
            {

            }
        }

        public void addUser(SystemUser user)
        {
            try
            {
                using (DB_Project db = new DB_Project())
                {
                    db.SystemUser.Add(user);
                    db.SaveChanges();
                }
            }
            catch
            {
            }
        }

        public void DeleteUser(String name)
        {
            using (DB_Project db = new DB_Project())
            {
                var user = db.SystemUser.Find(name);
                if (user != null)
                {
                    db.SystemUser.Attach(user);
                    db.SystemUser.Remove(user);
                    db.SaveChanges();
                }
            }
        }

        public bool checkNameUser(string name) {
            using (DB_Project db = new DB_Project())
            {
                var user = db.SystemUser.Find(name);
                if (user == null)
                {
                    return true;
                }
            }
            return false;
        }

        public SystemUser ChargeUser(String name)
        {
            using (DB_Project db = new DB_Project())
            {
                var user = db.SystemUser.Find(name);
                return user;
            }
        }
    }
}
