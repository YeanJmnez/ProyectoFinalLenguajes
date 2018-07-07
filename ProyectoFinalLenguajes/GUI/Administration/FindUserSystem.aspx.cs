using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;

namespace GUI.Administration
{
    public partial class FindUserSystem : System.Web.UI.Page
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
                    List<BLSystemUser> list = new List<BLSystemUser>();
                    list.Add(user);
                    grid_User.DataSource = list;
                    grid_User.DataBind();
                }
                else
                {
                    L_State.Text = "This user doesn't exist.";
                }
            }

        }

        protected void B_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}