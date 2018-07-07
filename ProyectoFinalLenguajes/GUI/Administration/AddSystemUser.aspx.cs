using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;

namespace GUI
{
    public partial class AddSystemUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            L_State.Enabled = false;
        }

        protected void B_addUSer_Click(object sender, EventArgs e)
        {

            String username = Text_Name.Text.Trim();
            String password = Text_Password.Text.Trim();
            string role = null;
            bool saveChange = true;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || Radio_Role.SelectedItem == null)
            {
                L_State.Enabled = true;
                L_State.Text = "No se puede dejar campos vacios.";
                saveChange = false;

            }


            if (saveChange)
            {
                role = Radio_Role.SelectedItem.Text;
                ManagerUserSystem manager = new ManagerUserSystem();
                bool state = manager.addUser(new BLSystemUser(username, password, role));

                if (!state)
                {
                    L_State.Text = "Ya existe un usuario con el mismo nombre";
                }
                else
                {
                    Response.Redirect("AddSystemUser.aspx");
                }
            }
        }
    }
}
