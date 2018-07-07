using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;

namespace GUI.Administration
{
    public partial class UpdateSystemUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            L_State.Enabled = false;
        }

        protected void B_Find_Click(object sender, EventArgs e)
        {
            bool saveChange = true;
            ManagerUserSystem manager = new ManagerUserSystem();

            if (string.IsNullOrEmpty(T_Code.Text.Trim()))
            {
                L_State.Enabled = true;
                L_State.Text = "Don't leave empty fields.";
                saveChange = false;

            }

            if (saveChange)
            {
                BLSystemUser user = manager.ChargeUser(T_Code.Text.Trim());
                if (user != null)
                {
                    Text_Name.Text = user.SystemUserName;
                    Text_Password.Text = user.SystemUserPassword;
                    string role = user.SystemUserRole;
                    if (role.Equals("Admin"))
                    {
                        role = "Administrator";
                    }
                    else
                    {
                        role = "Kitchen User";
                    }
                    Text_Role.Text = role;
                }
                else
                {
                    L_State.Text = "This user doesn't exist.";
                }
            }
        }

        protected void B_addUSer_Click(object sender, EventArgs e)
        {
            ManagerUserSystem manager = new ManagerUserSystem();

            String password = Text_Password.Text.Trim();
            string role = Text_Role.Text;
            bool saveChange = true;

            if (string.IsNullOrEmpty(password))
            {
                L_State.Enabled = true;
                L_State.Text = "Don't leave empty fields.";
                saveChange = false;
            }


            if (saveChange)
            {
                if (Radio_Role.SelectedItem == null)
                {
                    if (role.Equals("Administrator"))
                    {
                        role = "Admin";
                    }
                    else
                    {
                        role = "Kitchen User";
                    }
                }
                else
                {
                    role = Radio_Role.SelectedItem.Value;
                }
                manager.updateUser(new BLSystemUser(Text_Name.Text, password, role));
                Response.Redirect("UpdateSystemUser.aspx");
            }
        }

        protected void B_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}