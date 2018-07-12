using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class AdminSiteMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                lblUserName.Text = Session["username"].ToString();
            }
        }
        protected void lbLogOut_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}