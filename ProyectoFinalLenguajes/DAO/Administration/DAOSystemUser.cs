using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO;
using System.Data.SqlClient;

namespace DAO.Administration
{
  public class DAOSystemUser
    {

        public String checkUserCredentials(SystemUser su)
        {
            String result = "";

            SystemUser suFound = null;

            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                suFound = db.SystemUsers.Find(su.SystemUserName);

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
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                systemUser = db.SystemUsers.ToList();
            }
            return systemUser;
        }

        public void updateUser(SystemUser systemUser)
        {
            try
            {
                using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
                {
                    SystemUser User = db.SystemUsers.Find(systemUser.SystemUserName);
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
                using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
                {
                    db.SystemUsers.Add(user);
                    db.SaveChanges();
                }
            }
            catch
            {
            }
        }

        public void DeleteUser(String name)
        {
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                var user = db.SystemUsers.Find(name);
                if (user != null)
                {
                    db.SystemUsers.Attach(user);
                    db.SystemUsers.Remove(user);
                    db.SaveChanges();
                }
            }
        }

        public SystemUser ChargeUser(String name)
        {
            using (ProyectoLenguajes_Admin db = new ProyectoLenguajes_Admin())
            {
                var user = db.SystemUsers.Find(name);
                return user;
            }
        }
    }
}
