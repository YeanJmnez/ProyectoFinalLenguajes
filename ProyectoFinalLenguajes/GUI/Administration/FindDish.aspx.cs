using BL.Admistration;
using System;
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
            BLDish BLdish = new BLDish();
            BLdish.ChargeDish(int.Parse(TbFindDish.Text.Trim()));
            lbNombre.Visible = true;
            if(BLdish.Name == "")
            {
                lbNombre.Text = "nada";
            }
            lbNombre.Text = BLdish.Code +"3";
         
        }
   

    }
}