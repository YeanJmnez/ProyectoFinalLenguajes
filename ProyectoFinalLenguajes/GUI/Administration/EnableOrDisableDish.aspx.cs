using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;
using System.Collections;

namespace GUI
{
    public partial class EnableOrDisableDish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLDish dish = new BLDish();
          
         List<string> listString = dish.ListDishString();



            foreach (string item in listString)
            {
                List_User.Items.Add(item);
            }
        }

        protected void B_disable_Click(object sender, EventArgs e)
        {

        }

        protected void B_enable_Click(object sender, EventArgs e)
        {

        }
    }
}