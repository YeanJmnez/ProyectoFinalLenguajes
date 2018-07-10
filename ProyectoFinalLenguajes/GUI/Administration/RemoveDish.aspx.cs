using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;
using System.Collections;

namespace GUI.Administration
{
    public partial class RemoveDish : System.Web.UI.Page
    {
        BLDish BLdish = new BLDish();
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            grid.DataSource = BLdish.DishesList();
            grid.DataBind();
        }

        protected void btRemove_Click(object sender, EventArgs e)
        {
            
        }

        protected void btDelete_Click(object sender, EventArgs e)
        {
            BLdish.deleteDish(int.Parse(tbDeleteCode.Text.ToString()));
            Response.Redirect("RemoveDish.aspx");
        }
    }
}