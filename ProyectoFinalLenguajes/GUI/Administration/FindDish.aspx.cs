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
            if (!IsPostBack)
            {
                lbNombre.Visible = false;
            }
            else
            {
                TbFindDish.Text = "";
                lbNombre.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLDish BLdish = new BLDish();
            BLdish = BLdish.ChargeDish(int.Parse(TbFindDish.Text.Trim()));
            lbNombre.Text = BLdish.Name;



        }
   

    }
}