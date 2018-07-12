using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Admistration;

namespace GUI.Administration
{
    public partial class GUIManagerOrdes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void B_charge_Click(object sender, EventArgs e)
        {
            BLManagerOrders blorders = new BLManagerOrders();
            List<String> list = blorders.ListClientEmail(TxtEmail.Text.Trim());
            List_ClientFilter.Items.Clear();
            foreach (string item in list)
            {
                List_ClientFilter.Items.Add(item);
            }
        }

        protected void BtChageStatus_Click(object sender, EventArgs e)
        {
            BLManagerOrders blorders = new BLManagerOrders();
            string[] words = List_ClientFilter.SelectedItem.ToString().Split();

            if(RBOntime.Checked)
            {
                blorders.ChangeOrderStatus(words[2], RBOntime.Text);
            }
            if (RBAboutTime.Checked)
            {
                blorders.ChangeOrderStatus(words[2], RBAboutTime.Text);
            }
            if (RBCanceled.Checked)
            {
                blorders.ChangeOrderStatus(words[2], RBCanceled.Text);
            }
            if (RBComitted.Checked)
            {
                blorders.ChangeOrderStatus(words[2], RBComitted.Text);
            }
            if (RBLate.Checked)
            {
                blorders.ChangeOrderStatus(words[2], RBLate.Text);
            }

        }
    }
}