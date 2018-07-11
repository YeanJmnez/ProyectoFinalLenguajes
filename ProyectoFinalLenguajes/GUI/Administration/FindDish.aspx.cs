using BL.Admistration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI.Administration
{
    public partial class FindDish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ArrayList list = new ArrayList();
            BLDish BLdish = new BLDish();
            int i;
            if (int.TryParse(tbFind.Text.Trim(), out i)) { 
            BLdish = BLdish.ChargeDish(i);
                list.Add(BLdish);
            } else
            {
                list = BLdish.chargeRelatedDishes(tbFind.Text.Trim());
            }

   
            grid.DataSource = list;
            grid.DataBind();


        }
    }
}