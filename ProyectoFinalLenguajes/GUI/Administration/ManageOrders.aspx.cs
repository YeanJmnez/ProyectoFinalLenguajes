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
            String css = oneFilter.Attributes["style"];
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
            String css = box.Attributes["style"];
            String newCss = css.Replace("none", "block");
            box.Attributes.Add("style", newCss);
        }





        protected void Button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(dropDownone.SelectedValue) == 0)
            {
                String css = divClientCode.Attributes["style"];
                String newCss = css.Replace("none", "block");
                divClientCode.Attributes.Add("style", newCss);
            }

            if (int.Parse(dropDownone.SelectedValue) == 1)
            {
                String css = divBDate.Attributes["style"];
                String newCss = css.Replace("none", "block");
                divBDate.Attributes.Add("style", newCss);
            }
            Button1.Visible = false;

            if (int.Parse(dropDownone.SelectedValue) == 2)
            {
                String css = div3.Attributes["style"];
                String newCss = css.Replace("none", "block");
                div3.Attributes.Add("style", newCss);
            }
            Button1.Visible = false;


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string status = DropDownList1.SelectedItem.Text;
            List<string> listString = manager.ListOrderStatus(status);
            foreach (string item in listString)
            {
                List_User.Items.Add(item);
            }
            String css = box.Attributes["style"];
            String newCss = css.Replace("none", "block");
            box.Attributes.Add("style", newCss);

        }



        protected void Button4_Click(object sender, EventArgs e)
        {
         
            string txt = beginDate.SelectedDate.ToString();
            txt = txt.Replace("a", "");
            txt = txt.Replace("m", "");
            txt = txt.Replace(".", "");
            txt = txt.Trim();
            lbBeginDate.Text = txt;

            String css = divFdate.Attributes["style"];
            String newCss = css.Replace("none", "block");
            divFdate.Attributes.Add("style", newCss);
            Button4.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string txt2 = finalDate.SelectedDate.ToString();
            txt2 = txt2.Replace("a", "");
            txt2 = txt2.Replace("m", "");
            txt2 = txt2.Replace(".", "");
            txt2 = txt2.Trim();

            lbfinDate.Text = txt2;
            DateTime begin = DateTime.Parse(lbBeginDate.Text.ToString());
            DateTime end = DateTime.Parse(txt2);

            List<string> listString = manager.ListOrderDate(begin, end);
            foreach (string item in listString)
            {
                List_User.Items.Add(item);
            }
            String css = box.Attributes["style"];
            String newCss = css.Replace("none", "block");
            box.Attributes.Add("style", newCss);
            Button5.Visible = false;
        }
    }
}