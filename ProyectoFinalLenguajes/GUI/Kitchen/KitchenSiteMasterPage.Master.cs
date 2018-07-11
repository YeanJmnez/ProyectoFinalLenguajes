using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI.Kitchen
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lbLogOut_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("../Administration/Login.aspx");
        }
    }
}