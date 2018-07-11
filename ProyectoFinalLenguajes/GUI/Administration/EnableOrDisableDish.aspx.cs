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
        BLDish dish = new BLDish();
        protected void Page_Load(object sender, EventArgs e)
        {
 
         List<string> listString = dish.ListDishString();
            foreach (string item in listString)
            {
                List_User.Items.Add(item);
            }
        }

        protected void B_change_Click(object sender, EventArgs e)
        {
      
            string[] words = List_User.SelectedItem.ToString().Split();
            dish.ChangeState(int.Parse(words[1]));
          
            Response.Redirect("EnableOrDisableDish.aspx");
        }
    }
}