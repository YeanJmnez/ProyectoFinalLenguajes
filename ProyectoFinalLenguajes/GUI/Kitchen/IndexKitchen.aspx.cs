using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Kitchen;
namespace GUI.Kitchen
{
    public partial class IndexKitchen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ManagerOrder manager = new ManagerOrder();
            GridView1.DataSource = manager.ListKitchenModule();
            GridView1.DataBind();
        }
    }
}