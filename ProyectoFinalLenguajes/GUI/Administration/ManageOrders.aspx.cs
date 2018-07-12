using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;

namespace GUI.Administration
{
    public partial class ManageOrders : System.Web.UI.Page
    {
        BLManagerOrders manager = new BLManagerOrders();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            String css = divMuti.Attributes["style"];
            String newCss = css.Replace("none", "block");
            divMuti.Attributes.Add("style", newCss);
            bt2.Visible = false;
        }

        protected void bt2_Click(object sender, EventArgs e)
        {
            String css =  oneFilter.Attributes["style"];
            String newCss = css.Replace("none", "block");
            oneFilter.Attributes.Add("style", newCss);
            bt1.Visible = false;
        }



        protected void btfindbyClient(object sender, EventArgs e)
        {
            List<string> listString = manager.ListClientEmail(TxtClientEmail.Text.Trim());
            foreach (string item in listString)
            {
                List_User.Items.Add(item);
            }
        }





        protected void Button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(dropDownone.SelectedValue) == 0)
            {
                String css = divClientCode.Attributes["style"];
                String newCss = css.Replace("none", "block");
                divClientCode.Attributes.Add("style", newCss);
            }

            if (int.Parse(dropDownone.SelectedValue) == 2)
            {
                String css = div3.Attributes["style"];
                String newCss = css.Replace("none", "block");
                div3.Attributes.Add("style", newCss);
            }
            Button1.Visible = false;


        }
    }
}