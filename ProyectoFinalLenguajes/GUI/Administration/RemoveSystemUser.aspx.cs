using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;

namespace GUI.Administration
{
    public partial class RemoveSystemUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ManagerUserSystem manager = new ManagerUserSystem();
            List<String> list = manager.ListUserString();
            foreach (string item in list)
            {
                List_User.Items.Add(item);
            }
        }

        protected void B_Delete_Click(object sender, EventArgs e)
        {
            ManagerUserSystem manager = new ManagerUserSystem();
            string[] words = List_User.SelectedItem.ToString().Split();

            manager.deleteUser(words[1]);
            Response.Redirect("RemoveSystemUser.aspx");
        }

        protected void B_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}